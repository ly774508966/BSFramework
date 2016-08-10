﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BSFramework_Tools_Utils : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			BSFramework.Tools.Utils o;
			o=new BSFramework.Tools.Utils();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetURLFileSuffix_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetURLFileSuffix(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetURLFileName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetURLFileName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetKeyURLFileName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetKeyURLFileName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetURLFullFileName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetURLFullFileName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFileFullPath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetFileFullPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAssetFullPath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetAssetFullPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFileFullPathNoProtocol_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetFileFullPathNoProtocol(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDirectoryFullPathNoProtocol_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetDirectoryFullPathNoProtocol(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAssetPath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.GetAssetPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPlatformFolderForAssetBundles_s(IntPtr l) {
		try {
			var ret=BSFramework.Tools.Utils.GetPlatformFolderForAssetBundles();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Collect_s(IntPtr l) {
		try {
			BSFramework.Tools.Utils.Collect();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Execute_s(IntPtr l) {
		try {
			System.Collections.Generic.IList<System.Action> a1;
			checkType(l,1,out a1);
			BSFramework.Tools.Utils.Execute(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ConvertDateTimeInt_s(IntPtr l) {
		try {
			System.DateTime a1;
			checkValueType(l,1,out a1);
			var ret=BSFramework.Tools.Utils.ConvertDateTimeInt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currPersistentExist(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,BSFramework.Tools.Utils.currPersistentExist);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_currPersistentExist(IntPtr l) {
		try {
			System.Boolean v;
			checkType(l,2,out v);
			BSFramework.Tools.Utils.currPersistentExist=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dataPath(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,BSFramework.Tools.Utils.dataPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BSFramework.Tools.Utils");
		addMember(l,GetURLFileSuffix_s);
		addMember(l,GetURLFileName_s);
		addMember(l,GetKeyURLFileName_s);
		addMember(l,GetURLFullFileName_s);
		addMember(l,GetFileFullPath_s);
		addMember(l,GetAssetFullPath_s);
		addMember(l,GetFileFullPathNoProtocol_s);
		addMember(l,GetDirectoryFullPathNoProtocol_s);
		addMember(l,GetAssetPath_s);
		addMember(l,GetPlatformFolderForAssetBundles_s);
		addMember(l,Collect_s);
		addMember(l,Execute_s);
		addMember(l,ConvertDateTimeInt_s);
		addMember(l,"currPersistentExist",get_currPersistentExist,set_currPersistentExist,false);
		addMember(l,"dataPath",get_dataPath,null,false);
		createTypeMetatable(l,constructor, typeof(BSFramework.Tools.Utils));
	}
}
