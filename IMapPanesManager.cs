//////////////////////////////////////////////////////////////////////////
///���������:	IMapPanesManager
///��������:	��������� ��������� ��������� �� ������� ������ �����
///				��� �������� �������.
///�����:		�.�. �������
//////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using LightCom.Common;

namespace LightCom.UI
{
	/// <summary>
	/// 
	/// </summary>
	public interface IMapPanesManager
	{
		/// <summary>
		/// ���������� ��������� ����� ����� ��� �������� ���������� ���������
		/// </summary>
		/// <param name="mapDimension">������� ��� ������� ���������� ������� �����������</param>
		/// <param name="panes">�������� ��������, ������ ������ �������� � �������� �������</param>
		/// <returns>true ���� ������, ����� false</returns>
		bool GetMapPanes(Rectangle mapDimension, out MapPane [] panes);
		/// <summary>
		/// ���������� ��������� ����� ����� ��� �������� �������������� ���������
		/// </summary>
		/// <param name="mapDimension">������� ��� ������� ���������� ������� �����������</param>
		/// <param name="mapImage">�������� ��������, ������ ������ �������� � �������� �������</param>
		/// <returns>true ���� ������, ����� false</returns>
		bool GetMapPanes(RectangleF mapDimension, out MapPane [] panes);
		/// <summary>
		/// ���������� ��������� ���������
		/// </summary>
		void Reset();
		/// <summary>
		/// �������� �� �� ��� �������� ����� ���������������
		/// </summary>
		bool IsInit
		{
			get;
		}
		/// <summary>
		/// ������ ��� ������ � ������ �������������� ��������������� ������������.
		/// </summary>
		IPositionMapper PositionMapper
		{
			get;
		}
	}
}
