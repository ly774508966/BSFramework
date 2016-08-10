﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GUISettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.GUISettings o;
			o=new UnityEngine.GUISettings();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_doubleClickSelectsWord(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.doubleClickSelectsWord);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_doubleClickSelectsWord(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.doubleClickSelectsWord=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tripleClickSelectsLine(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tripleClickSelectsLine);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tripleClickSelectsLine(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.tripleClickSelectsLine=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cursorColor(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cursorColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cursorColor(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.cursorColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cursorFlashSpeed(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cursorFlashSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cursorFlashSpeed(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.cursorFlashSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionColor(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.selectionColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionColor(IntPtr l) {
		try {
			UnityEngine.GUISettings self=(UnityEngine.GUISettings)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.selectionColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GUISettings");
		addMember(l,"doubleClickSelectsWord",get_doubleClickSelectsWord,set_doubleClickSelectsWord,true);
		addMember(l,"tripleClickSelectsLine",get_tripleClickSelectsLine,set_tripleClickSelectsLine,true);
		addMember(l,"cursorColor",get_cursorColor,set_cursorColor,true);
		addMember(l,"cursorFlashSpeed",get_cursorFlashSpeed,set_cursorFlashSpeed,true);
		addMember(l,"selectionColor",get_selectionColor,set_selectionColor,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GUISettings));
	}
}
