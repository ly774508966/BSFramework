using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUIUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.GUIUtility o;
			o=new UnityEngine.GUIUtility();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetControlID_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.FocusType a1;
				checkEnum(l,1,out a1);
				var ret=UnityEngine.GUIUtility.GetControlID(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.FocusType))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.FocusType a2;
				checkEnum(l,2,out a2);
				var ret=UnityEngine.GUIUtility.GetControlID(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.FocusType),typeof(UnityEngine.Rect))){
				UnityEngine.FocusType a1;
				checkEnum(l,1,out a1);
				UnityEngine.Rect a2;
				checkValueType(l,2,out a2);
				var ret=UnityEngine.GUIUtility.GetControlID(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GUIContent),typeof(UnityEngine.FocusType))){
				UnityEngine.GUIContent a1;
				checkType(l,1,out a1);
				UnityEngine.FocusType a2;
				checkEnum(l,2,out a2);
				var ret=UnityEngine.GUIUtility.GetControlID(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.GUIContent),typeof(UnityEngine.FocusType),typeof(UnityEngine.Rect))){
				UnityEngine.GUIContent a1;
				checkType(l,1,out a1);
				UnityEngine.FocusType a2;
				checkEnum(l,2,out a2);
				UnityEngine.Rect a3;
				checkValueType(l,3,out a3);
				var ret=UnityEngine.GUIUtility.GetControlID(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.FocusType),typeof(UnityEngine.Rect))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.FocusType a2;
				checkEnum(l,2,out a2);
				UnityEngine.Rect a3;
				checkValueType(l,3,out a3);
				var ret=UnityEngine.GUIUtility.GetControlID(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetStateObject_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.GUIUtility.GetStateObject(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int QueryStateObject_s(IntPtr l) {
		try {
			System.Type a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.GUIUtility.QueryStateObject(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ExitGUI_s(IntPtr l) {
		try {
			UnityEngine.GUIUtility.ExitGUI();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GUIToScreenPoint_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GUIUtility.GUIToScreenPoint(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToGUIPoint_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GUIUtility.ScreenToGUIPoint(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToGUIRect_s(IntPtr l) {
		try {
			UnityEngine.Rect a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.GUIUtility.ScreenToGUIRect(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RotateAroundPivot_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.GUIUtility.RotateAroundPivot(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScaleAroundPivot_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,2,out a2);
			UnityEngine.GUIUtility.ScaleAroundPivot(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hotControl(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GUIUtility.hotControl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hotControl(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.GUIUtility.hotControl=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardControl(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GUIUtility.keyboardControl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardControl(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.GUIUtility.keyboardControl=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_systemCopyBuffer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GUIUtility.systemCopyBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_systemCopyBuffer(IntPtr l) {
		try {
			string v;
			checkType(l,2,out v);
			UnityEngine.GUIUtility.systemCopyBuffer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasModalWindow(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.GUIUtility.hasModalWindow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUIUtility");
		addMember(l,GetControlID_s);
		addMember(l,GetStateObject_s);
		addMember(l,QueryStateObject_s);
		addMember(l,ExitGUI_s);
		addMember(l,GUIToScreenPoint_s);
		addMember(l,ScreenToGUIPoint_s);
		addMember(l,ScreenToGUIRect_s);
		addMember(l,RotateAroundPivot_s);
		addMember(l,ScaleAroundPivot_s);
		addMember(l,"hotControl",get_hotControl,set_hotControl,false);
		addMember(l,"keyboardControl",get_keyboardControl,set_keyboardControl,false);
		addMember(l,"systemCopyBuffer",get_systemCopyBuffer,set_systemCopyBuffer,false);
		addMember(l,"hasModalWindow",get_hasModalWindow,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUIUtility));
	}
}
