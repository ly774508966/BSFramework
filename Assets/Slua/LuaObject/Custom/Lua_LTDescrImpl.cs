using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LTDescrImpl : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			LTDescrImpl o;
			o=new LTDescrImpl();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int reset(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			self.reset();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int cleanup(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			self.cleanup();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int init(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			self.init();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setFromColor(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			var ret=self.setFromColor(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int pause(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			var ret=self.pause();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int resume(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			var ret=self.resume();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setAxis(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.setAxis(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setDelay(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setDelay(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setEase(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.AnimationCurve))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				UnityEngine.AnimationCurve a1;
				checkType(l,2,out a1);
				var ret=self.setEase(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(LeanTweenType))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				LeanTweenType a1;
				checkEnum(l,2,out a1);
				var ret=self.setEase(a1);
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
	static public int setOvershoot(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setOvershoot(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setPeriod(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setPeriod(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setTo(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Transform))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				var ret=self.setTo(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				var ret=self.setTo(a1);
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
	static public int setFrom(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(float))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				var ret=self.setFrom(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Vector3))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				var ret=self.setFrom(a1);
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
	static public int setDiff(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.setDiff(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setHasInitialized(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setHasInitialized(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setId(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.UInt32 a1;
			checkType(l,2,out a1);
			var ret=self.setId(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setTime(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setSpeed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setSpeed(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setRepeat(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.setRepeat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setLoopType(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LeanTweenType a1;
			checkEnum(l,2,out a1);
			var ret=self.setLoopType(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setUseEstimatedTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setUseEstimatedTime(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setIgnoreTimeScale(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setIgnoreTimeScale(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setUseFrames(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setUseFrames(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setUseManualTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setUseManualTime(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setLoopCount(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.setLoopCount(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setLoopOnce(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			var ret=self.setLoopOnce();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setLoopClamp(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				var ret=self.setLoopClamp();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.setLoopClamp(a1);
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
	static public int setLoopPingPong(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				var ret=self.setLoopPingPong();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.setLoopPingPong(a1);
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
	static public int setOnComplete(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(System.Action<object>))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<System.Object> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnComplete(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnComplete(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<System.Object> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.setOnComplete(a1,a2);
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
	static public int setOnCompleteParam(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.setOnCompleteParam(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnUpdate(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Color,object>))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Color,System.Object> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnUpdate(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Color>))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Color> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnUpdate(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<System.Single>))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<System.Single> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnUpdate(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Vector2>),typeof(System.Object))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Vector2> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.setOnUpdate(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Vector3>),typeof(System.Object))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Vector3> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.setOnUpdate(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<System.Single,object>),typeof(System.Object))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<System.Single,System.Object> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.setOnUpdate(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Vector3,object>),typeof(System.Object))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Vector3,System.Object> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.setOnUpdate(a1,a2);
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
	static public int setOnUpdateRatio(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<System.Single,System.Single> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.setOnUpdateRatio(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnUpdateObject(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<System.Single,System.Object> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.setOnUpdateObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnUpdateVector2(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Vector2> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.setOnUpdateVector2(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnUpdateVector3(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Vector3> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.setOnUpdateVector3(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnUpdateColor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Color,object>))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Color,System.Object> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnUpdateColor(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Action<UnityEngine.Color>))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				System.Action<UnityEngine.Color> a1;
				LuaDelegation.checkDelegate(l,2,out a1);
				var ret=self.setOnUpdateColor(a1);
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
	static public int setOnUpdateParam(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.setOnUpdateParam(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOrientToPath(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setOrientToPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOrientToPath2d(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setOrientToPath2d(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setRect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.RectTransform))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				UnityEngine.RectTransform a1;
				checkType(l,2,out a1);
				var ret=self.setRect(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rect))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				UnityEngine.Rect a1;
				checkValueType(l,2,out a1);
				var ret=self.setRect(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(LTRect))){
				LTDescrImpl self=(LTDescrImpl)checkSelf(l);
				LTRect a1;
				checkType(l,2,out a1);
				var ret=self.setRect(a1);
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
	static public int setPath(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LTBezierPath a1;
			checkType(l,2,out a1);
			var ret=self.setPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setPoint(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.setPoint(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setDestroyOnComplete(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setDestroyOnComplete(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setAudio(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.setAudio(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnCompleteOnRepeat(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setOnCompleteOnRepeat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnCompleteOnStart(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setOnCompleteOnStart(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setSprites(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Sprite[] a1;
			checkArray(l,2,out a1);
			var ret=self.setSprites(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setFrameRate(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setFrameRate(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setOnStart(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			var ret=self.setOnStart(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setDirection(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.setDirection(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int setRecursive(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.setRecursive(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rectTransform(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rectTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rectTransform(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.RectTransform v;
			checkType(l,2,out v);
			self.rectTransform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiText(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uiText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiText(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.UI.Text v;
			checkType(l,2,out v);
			self.uiText=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uiImage(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uiImage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiImage(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.UI.Image v;
			checkType(l,2,out v);
			self.uiImage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprites(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sprites);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprites(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Sprite[] v;
			checkArray(l,2,out v);
			self.sprites=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_toggle(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.toggle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_toggle(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.toggle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useEstimatedTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useEstimatedTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useEstimatedTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useEstimatedTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useFrames(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useFrames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useFrames(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useFrames=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useManualTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useManualTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useManualTime(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useManualTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasInitiliazed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasInitiliazed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasInitiliazed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hasInitiliazed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPhysics(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasPhysics);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasPhysics(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hasPhysics=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onCompleteOnRepeat(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onCompleteOnRepeat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCompleteOnRepeat(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.onCompleteOnRepeat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onCompleteOnStart(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onCompleteOnStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCompleteOnStart(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.onCompleteOnStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useRecursion(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useRecursion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useRecursion(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useRecursion=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_passed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.passed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_passed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.passed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delay(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.delay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delay(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.delay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.speed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.speed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lastVal(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lastVal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lastVal(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lastVal=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loopCount(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loopCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loopCount(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.loopCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_counter(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.counter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_counter(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.counter=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_direction(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.direction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_direction(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.direction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_directionLast(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.directionLast);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_directionLast(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.directionLast=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_overshoot(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.overshoot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_overshoot(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.overshoot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_period(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.period);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_period(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.period=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_destroyOnComplete(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.destroyOnComplete);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_destroyOnComplete(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.destroyOnComplete=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_trans(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.trans);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_trans(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.trans=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_toTrans(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.toTrans);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_toTrans(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.toTrans=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ltRect(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ltRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_ltRect(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LTRect v;
			checkType(l,2,out v);
			self.ltRect=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_from(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.from);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_from(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.from=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_to(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.to);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_to(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.to=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_diff(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.diff);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_diff(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.diff=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.point);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_point(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.point=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_axis(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.axis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_axis(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.axis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_origRotation(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.origRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_origRotation(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.origRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_path(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_path(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LTBezierPath v;
			checkType(l,2,out v);
			self.path=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spline(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.spline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spline(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LTSpline v;
			checkType(l,2,out v);
			self.spline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			TweenAction v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenType(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.tweenType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenType(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LeanTweenType v;
			checkEnum(l,2,out v);
			self.tweenType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationCurve(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.animationCurve);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animationCurve(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.AnimationCurve v;
			checkType(l,2,out v);
			self.animationCurve=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loopType(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.loopType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loopType(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			LeanTweenType v;
			checkEnum(l,2,out v);
			self.loopType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasUpdateCallback(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasUpdateCallback);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasUpdateCallback(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hasUpdateCallback=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateFloat(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<System.Single> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateFloat=v;
			else if(op==1) self.onUpdateFloat+=v;
			else if(op==2) self.onUpdateFloat-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateFloatRatio(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<System.Single,System.Single> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateFloatRatio=v;
			else if(op==1) self.onUpdateFloatRatio+=v;
			else if(op==2) self.onUpdateFloatRatio-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateFloatObject(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<System.Single,object> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateFloatObject=v;
			else if(op==1) self.onUpdateFloatObject+=v;
			else if(op==2) self.onUpdateFloatObject-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateVector2(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Vector2> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateVector2=v;
			else if(op==1) self.onUpdateVector2+=v;
			else if(op==2) self.onUpdateVector2-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateVector3(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Vector3> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateVector3=v;
			else if(op==1) self.onUpdateVector3+=v;
			else if(op==2) self.onUpdateVector3-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateVector3Object(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Vector3,object> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateVector3Object=v;
			else if(op==1) self.onUpdateVector3Object+=v;
			else if(op==2) self.onUpdateVector3Object-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateColor(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Color> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateColor=v;
			else if(op==1) self.onUpdateColor+=v;
			else if(op==2) self.onUpdateColor-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateColorObject(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<UnityEngine.Color,object> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onUpdateColorObject=v;
			else if(op==1) self.onUpdateColorObject+=v;
			else if(op==2) self.onUpdateColorObject-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onComplete(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onComplete=v;
			else if(op==1) self.onComplete+=v;
			else if(op==2) self.onComplete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCompleteObject(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action<object> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onCompleteObject=v;
			else if(op==1) self.onCompleteObject+=v;
			else if(op==2) self.onCompleteObject-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onCompleteParam(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onCompleteParam);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onCompleteParam(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Object v;
			checkType(l,2,out v);
			self.onCompleteParam=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onUpdateParam(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.onUpdateParam);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onUpdateParam(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Object v;
			checkType(l,2,out v);
			self.onUpdateParam=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onStart(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			System.Action v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onStart=v;
			else if(op==1) self.onStart+=v;
			else if(op==2) self.onStart-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spriteRen(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.spriteRen);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spriteRen(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			UnityEngine.SpriteRenderer v;
			checkType(l,2,out v);
			self.spriteRen=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uniqueId(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uniqueId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id(IntPtr l) {
		try {
			LTDescrImpl self=(LTDescrImpl)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LTDescrImpl");
		addMember(l,reset);
		addMember(l,cleanup);
		addMember(l,init);
		addMember(l,setFromColor);
		addMember(l,pause);
		addMember(l,resume);
		addMember(l,setAxis);
		addMember(l,setDelay);
		addMember(l,setEase);
		addMember(l,setOvershoot);
		addMember(l,setPeriod);
		addMember(l,setTo);
		addMember(l,setFrom);
		addMember(l,setDiff);
		addMember(l,setHasInitialized);
		addMember(l,setId);
		addMember(l,setTime);
		addMember(l,setSpeed);
		addMember(l,setRepeat);
		addMember(l,setLoopType);
		addMember(l,setUseEstimatedTime);
		addMember(l,setIgnoreTimeScale);
		addMember(l,setUseFrames);
		addMember(l,setUseManualTime);
		addMember(l,setLoopCount);
		addMember(l,setLoopOnce);
		addMember(l,setLoopClamp);
		addMember(l,setLoopPingPong);
		addMember(l,setOnComplete);
		addMember(l,setOnCompleteParam);
		addMember(l,setOnUpdate);
		addMember(l,setOnUpdateRatio);
		addMember(l,setOnUpdateObject);
		addMember(l,setOnUpdateVector2);
		addMember(l,setOnUpdateVector3);
		addMember(l,setOnUpdateColor);
		addMember(l,setOnUpdateParam);
		addMember(l,setOrientToPath);
		addMember(l,setOrientToPath2d);
		addMember(l,setRect);
		addMember(l,setPath);
		addMember(l,setPoint);
		addMember(l,setDestroyOnComplete);
		addMember(l,setAudio);
		addMember(l,setOnCompleteOnRepeat);
		addMember(l,setOnCompleteOnStart);
		addMember(l,setSprites);
		addMember(l,setFrameRate);
		addMember(l,setOnStart);
		addMember(l,setDirection);
		addMember(l,setRecursive);
		addMember(l,"rectTransform",get_rectTransform,set_rectTransform,true);
		addMember(l,"uiText",get_uiText,set_uiText,true);
		addMember(l,"uiImage",get_uiImage,set_uiImage,true);
		addMember(l,"sprites",get_sprites,set_sprites,true);
		addMember(l,"toggle",get_toggle,set_toggle,true);
		addMember(l,"useEstimatedTime",get_useEstimatedTime,set_useEstimatedTime,true);
		addMember(l,"useFrames",get_useFrames,set_useFrames,true);
		addMember(l,"useManualTime",get_useManualTime,set_useManualTime,true);
		addMember(l,"hasInitiliazed",get_hasInitiliazed,set_hasInitiliazed,true);
		addMember(l,"hasPhysics",get_hasPhysics,set_hasPhysics,true);
		addMember(l,"onCompleteOnRepeat",get_onCompleteOnRepeat,set_onCompleteOnRepeat,true);
		addMember(l,"onCompleteOnStart",get_onCompleteOnStart,set_onCompleteOnStart,true);
		addMember(l,"useRecursion",get_useRecursion,set_useRecursion,true);
		addMember(l,"passed",get_passed,set_passed,true);
		addMember(l,"delay",get_delay,set_delay,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"lastVal",get_lastVal,set_lastVal,true);
		addMember(l,"loopCount",get_loopCount,set_loopCount,true);
		addMember(l,"counter",get_counter,set_counter,true);
		addMember(l,"direction",get_direction,set_direction,true);
		addMember(l,"directionLast",get_directionLast,set_directionLast,true);
		addMember(l,"overshoot",get_overshoot,set_overshoot,true);
		addMember(l,"period",get_period,set_period,true);
		addMember(l,"destroyOnComplete",get_destroyOnComplete,set_destroyOnComplete,true);
		addMember(l,"trans",get_trans,set_trans,true);
		addMember(l,"toTrans",get_toTrans,set_toTrans,true);
		addMember(l,"ltRect",get_ltRect,set_ltRect,true);
		addMember(l,"from",get_from,set_from,true);
		addMember(l,"to",get_to,set_to,true);
		addMember(l,"diff",get_diff,set_diff,true);
		addMember(l,"point",get_point,set_point,true);
		addMember(l,"axis",get_axis,set_axis,true);
		addMember(l,"origRotation",get_origRotation,set_origRotation,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"spline",get_spline,set_spline,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"tweenType",get_tweenType,set_tweenType,true);
		addMember(l,"animationCurve",get_animationCurve,set_animationCurve,true);
		addMember(l,"loopType",get_loopType,set_loopType,true);
		addMember(l,"hasUpdateCallback",get_hasUpdateCallback,set_hasUpdateCallback,true);
		addMember(l,"onUpdateFloat",null,set_onUpdateFloat,true);
		addMember(l,"onUpdateFloatRatio",null,set_onUpdateFloatRatio,true);
		addMember(l,"onUpdateFloatObject",null,set_onUpdateFloatObject,true);
		addMember(l,"onUpdateVector2",null,set_onUpdateVector2,true);
		addMember(l,"onUpdateVector3",null,set_onUpdateVector3,true);
		addMember(l,"onUpdateVector3Object",null,set_onUpdateVector3Object,true);
		addMember(l,"onUpdateColor",null,set_onUpdateColor,true);
		addMember(l,"onUpdateColorObject",null,set_onUpdateColorObject,true);
		addMember(l,"onComplete",null,set_onComplete,true);
		addMember(l,"onCompleteObject",null,set_onCompleteObject,true);
		addMember(l,"onCompleteParam",get_onCompleteParam,set_onCompleteParam,true);
		addMember(l,"onUpdateParam",get_onUpdateParam,set_onUpdateParam,true);
		addMember(l,"onStart",null,set_onStart,true);
		addMember(l,"spriteRen",get_spriteRen,set_spriteRen,true);
		addMember(l,"uniqueId",get_uniqueId,null,true);
		addMember(l,"id",get_id,null,true);
		createTypeMetatable(l,constructor, typeof(LTDescrImpl));
	}
}
