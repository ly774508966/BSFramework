require "BSFramework.Log.TablePrint"

local function LuaLog(...)   
   if true then
       print(...)
   end
end

local LuaLogTemp, print_ptk = function() end , function() end
local function setLuaLog(openStatus,preStr)
  if openStatus == 1 then
        if not preStr then   return LuaLog, tablePrint_ptk
        else return function (...) LuaLog("[" .. preStr .. "]",...) end, function(t) LuaLog("\n     [" .. preStr .. "] --->") print(util.getInstance():serialise_value(t))  end 
        end 
    else 
        return LuaLogTemp, print_ptk 
    end
end


-- local function setLuaLog(openStatus,preStr)
--   if openStatus == 1 then
--         if not preStr then   return LuaLog, tablePrint_ptk
--         else return function (...) LuaLog("[" .. preStr .. "]",...) end, function(t) LuaLog("\n     [" .. preStr .. "] --->") tablePrint_ptk(t)  end 
--         end 
--     else 
--         return LuaLogTemp, print_ptk 
--     end
-- end

Declare("setLuaLog", setLuaLog)