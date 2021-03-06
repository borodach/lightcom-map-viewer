////////////////////////////////////////////////////////////////////////////////
//                                                                            
//  File:           ISettings.cs
//
//  Facility:       ???????? ????????.
//
//
//  Abstract:       ?????? ???????? ??????????? ??????????, ??????? ????? 
//                  ????????????? ??????, ?????? ?????????? ??????? ???? 
//                  ?????????.
//
//  Environment:    VC# 7.1
//
//  Author:         ?????? ?. ?.
//
//  Creation Date:  13/09/2005
//
////////////////////////////////////////////////////////////////////////////////

using System;

namespace GPS.Common
{
/// 
/// <summary>
/// ????????? ?????????? ???????? ???????.
/// </summary>
/// 

public interface ISettings 
{

//////////////////////////////////////////////////////////////////////////////// 
/// 
/// <summary>
/// ?????????? ????????? ??????? ? ????????? ?????????.
/// </summary>
/// 
//////////////////////////////////////////////////////////////////////////////// 

void Reset ();

//////////////////////////////////////////////////////////////////////////////// 
/// 
/// <summary>
/// ????????? ????????? ??????? ? ???????? ?????????.
/// </summary>
/// <param name="storage">????????? ?????????? ??????????.</param>
/// <returns>?????????? true, ???? ?????????? ?????? ???????.
/// </returns>
/// 
//////////////////////////////////////////////////////////////////////////////// 

bool Save (ISettingsStorage storage);

//////////////////////////////////////////////////////////////////////////////// 
/// 
/// <summary>
/// ????????? ????????? ??????? ?? ????????? ?????????.
/// </summary>
/// <param name="storage">????????? ?????????? ??????????.</param>
/// <returns>?????????? true, ???? ???????? ?????? ???????.
/// </returns>
///
//////////////////////////////////////////////////////////////////////////////// 

bool Load (ISettingsStorage storage);
}
}


