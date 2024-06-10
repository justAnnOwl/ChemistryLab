using UnityEngine;
using System;

public class GameCursor : MonoBehaviour
{
	public Texture2D cursorNormal;
	public Texture2D cursorButton;
	public Texture2D cursorAdvice;
	public int size = 80; // размер курсора по ширине и высоте
	public enum ProjectMode { Project3D = 0, Project2D = 1 };
	public ProjectMode mode = ProjectMode.Project3D;
	
	private Vector2 _offset;
	private Texture2D _cursor;
	private bool _adviceMode;

	private void Awake()
	{
	//	adviceMode= false;
		Cursor.visible = false; // скрываем системный курсор
								//if(mode == ProjectMode.Project2D) Camera.main.orthographic = true; // для RaycastHit2D, камера должна быть в ортогональном режиме
	}

	private void MainCursor(string tags)
	{
		var adviceActivity = gameObject.AddComponent<AdviceActivity>();
		if (tags is "Button" or "GameObject" or "Tube")
		{
			if (_adviceMode == true)
			{
				Console.WriteLine("ADVICE");
				_cursor = cursorAdvice;
			}
			else _cursor = cursorButton;

		}
		else // курсор по умолчанию
		{
			_offset = Vector2.zero;
			_cursor = cursorNormal;
		}
	}

	public void SetActiveAdviceMode()
	{
		_adviceMode = !_adviceMode;
	}

	private void Update()
	{
		if (mode == ProjectMode.Project3D)
		{
			var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
				MainCursor(hit.transform.tag);
			else // если луч никуда не попадет
			{
				_offset = Vector2.zero;
				_cursor = cursorNormal;
			}
		}
		else
		{
			var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			if (hit.transform != null)
				MainCursor(hit.transform.tag);
			else
			{
				_offset = Vector2.zero;
				_cursor = cursorNormal;
			}
		}
	}

	private void OnGUI()
	{
		var mousePos = Event.current.mousePosition;
		GUI.depth = 999; // поверх остальных элементов
		GUI.Label(new Rect(mousePos.x + _offset.x, mousePos.y + _offset.y, size, size), _cursor);
	}
}


