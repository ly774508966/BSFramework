using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_BSFramework_Asset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			BSFramework.Asset o;
			System.String a1;
			checkType(l,2,out a1);
			BSFramework.Bundle a2;
			checkType(l,3,out a2);
			System.String a3;
			checkType(l,4,out a3);
			o=new BSFramework.Asset(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Load(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
				self.Load();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
				UnityEngine.MonoBehaviour a1;
				checkType(l,2,out a1);
				var ret=self.Load(a1);
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
	static public int UnLoad(IntPtr l) {
		try {
			BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
			self.UnLoad();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CoroutineProvider(IntPtr l) {
		try {
			BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CoroutineProvider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_CoroutineProvider(IntPtr l) {
		try {
			BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
			UnityEngine.MonoBehaviour v;
			checkType(l,2,out v);
			self.CoroutineProvider=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_LoadAssetAsync(IntPtr l) {
		try {
			BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
			System.Func<BSFramework.Bundle,BSFramework.Asset.AsyncRequest> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.LoadAssetAsync=v;
			else if(op==1) self.LoadAssetAsync+=v;
			else if(op==2) self.LoadAssetAsync-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_OnAssetLoaded(IntPtr l) {
		try {
			BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
			System.Action<UnityEngine.Object,BSFramework.Asset> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.OnAssetLoaded=v;
			else if(op==1) self.OnAssetLoaded+=v;
			else if(op==2) self.OnAssetLoaded-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_OnProgress(IntPtr l) {
		try {
			BSFramework.Asset self=(BSFramework.Asset)checkSelf(l);
			System.Action<System.Single> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.OnProgress=v;
			else if(op==1) self.OnProgress+=v;
			else if(op==2) self.OnProgress-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"BSFramework.Asset");
		addMember(l,Load);
		addMember(l,UnLoad);
		addMember(l,"CoroutineProvider",get_CoroutineProvider,set_CoroutineProvider,true);
		addMember(l,"LoadAssetAsync",null,set_LoadAssetAsync,true);
		addMember(l,"OnAssetLoaded",null,set_OnAssetLoaded,true);
		addMember(l,"OnProgress",null,set_OnProgress,true);
		createTypeMetatable(l,constructor, typeof(BSFramework.Asset));
	}
}
