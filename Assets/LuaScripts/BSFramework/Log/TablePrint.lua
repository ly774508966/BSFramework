--[[ ======================================= 监控表\默认值 华丽分割 =======================================]]
local uniqueDefaultKey = {} -- unique key  默认值
local mt_temp = {__index = function (t) return t[uniqueDefaultKey] end} 
-- local 
local setDefaultTracker = function (t, d)
    t[uniqueDefaultKey] = d
    setmetatable(t, mt_temp)
end


local trackCount = 0
local trackerIndex = {} --create private index
local trackerMt = {
      __index = function (t,k) 
                  trackCount = trackCount+1
                  print("* [" .. tostring(trackCount) .. "] " .. tostring(t)  .. " access to element " .. tostring(k)) 
                  return t[trackerIndex][k] 
               end,
      __newindex = function (t,k,v) 
                     trackCount = trackCount+1
                     print("* [" .. tostring(trackCount) .. "] update of element " .. tostring(k) .. " to " .. tostring(v)) 
                     t[trackerIndex][k] = v 
                   end
}

local function tablePrint_track(t)
   trackCount = 0
   local proxy = {}
   proxy[trackerIndex] = t
   setmetatable(proxy,trackerMt)
   return proxy
end

--[[ ======================================= 打印表 华丽分割 =======================================]]
-- at = {"adf","dfasdf","fgfg"}
-- setDefault(at,2)
-- at = track(at)   -- 加这一行就行

-- at[2] = "hello"
-- at[2] = "world"
-- print(at["fg"])



-- setmetatable(t,mt) ,当对 表 t 进行操作时，会先检测t是否有表Metatable，如果有则检测表Metatable中是否有相应的域（如__add域），定义__add的行为： mt.__add = function aFun() end
-- setmetatable(t, mt) Set.mt.__add = Set.union 
-- 算数运算 metamethods 固有域名 __add（加） ,__mul,__sub（减）,__div（除）,__unm（负）,__pow（幂）,__concat（连接）
-- 关系运算 metamethods 固有域名: __eq(等于),__lt(小于),__le(小于等于)
local Set = {}
Set.mt = {}

function Set.new (t)
    if(type(t)=="userdata") then
      return {}
    end
    local set = {}
    setmetatable(set, Set.mt)
    for _, l in pairs(t) do 
   		-- print(_,l) 
   		set[_] = l 
   	end
    return set
end

function Set.union (a,b)      --连接包含key
	if getmetatable(a) ~= Set.mt or
		getmetatable(b) ~= Set.mt then error("attempt to `add' a set with a non-set value", 2)
	end
   	local res = Set.new{}

   	local numOfalist = 0	
   	-- for _k,v in pairs(a) do 	--计算a中非key-vlaue的元素
   	-- 	 if(tonumber(_k)) then 
   	-- 	 	numOfalist = numOfalist +1
   	-- 	 end
   	-- end
      numOfalist = table.maxn(a)
   	-- table.getn(a)
   	-- print(numOfalist)
   	for _k,v in pairs(a) do 
   		-- print(_k,v) 
   		res[_k] = v 
   	end
   	for _k,v in pairs(b) do 
   		if(tonumber(_k)) then
   			res[_k+numOfalist] = v 
   		else
   			res[_k] = v 
   		end
   	end
   	return res
end

function Set.unionNoKey (a,b)    --无key连接
      local res = Set.new{}
      local indexTemp = 1
      for _k,v in pairs(a) do 
         res[indexTemp] = v 
         indexTemp = indexTemp + 1
      end
      for _k,v in pairs(b) do 
         res[indexTemp] = v 
         indexTemp = indexTemp + 1
      end
      return res
end

function Set.intersection (a,b)
   	local res = Set.new{}
   	for k in pairs(a) do
		res[k] = b[k]
	end
   	return res
end

local function appendTabWith(strOri, dig)
  for i=2,dig do
    strOri = strOri .. "\t" 
    -- strOri = strOri .. "      " 
  end
  return strOri
end 

function Set.tostring (set)      --打印 带key
   return Set.tostringWithDig (set,2)
end

local function splitFor2Table(aTable)     -- 非key元素考前排
  if type(aTable)~="table" then return nil end 
  local reTab1, reTab2 = {}, {}
  for k,v in pairs(aTable) do 
    if type(v)~="table" then 
      reTab1[k]=v 
    else 
      reTab2[k]=v
    end 
  end 

  return reTab1, reTab2
end 

function Set.tostringWithDig (set,dig)      --打印 带key
    local kStr = ""
    local s = ""
    if 2==dig then 
      s = s .. "\n" .. "{ " 
    end 

   	local sep = ""
    local lastIsTable = nil   -- lastIsTable：true -上次是table  ； lastIsTable：false -上次是string
    local firstEnter = true   -- 第一次进入
    local setCo, coTemp = 0, 0 

    for _k,e in pairs(set) do
      setCo = setCo+1
    end 

   	-- for _k,e in pairs(set) do
    local function execFun(_k, e)
   		-- print("arg:", _k,e)
		  local eIsTable = ( type(e)=="table" )

      if firstEnter or lastIsTable == true then -- 第一次进入 或者 上次是 table
        firstEnter = false
        lastIsTable = nil
        s = s .. "\n"
        s = appendTabWith(s,dig)
      end 

      if lastIsTable==false and eIsTable then   -- 上次是string 且 本次是table
        lastIsTable = nil 
        s = s .. "\n"
        s = appendTabWith(s,dig)
      end 

      if(type(_k)=="number") then  -- key
        kStr = tostring(_k)
        s = s .. sep .. "[" .. kStr .. "]" .. ":"
      else
        kStr = tostring(_k)
	      s = s .. sep .. kStr .. ":"
      end

			if type(e) == "boolean" then if e then e = "true" else e = "false" end 
			elseif type(e) == "function" then e = "__Function"  
      elseif(type(e)=="userdata") then 
        e = "__UserData"  
      end
				
      if eIsTable then
        s = s .. "\n"
        s = appendTabWith(s,dig)
        s = s .. " {"
        s = s .. "\t\t\t\t\t|-" .. dig
        s = s .. Set.tostringWithDig(e, dig+1)

        s = s .. "\n"
        s = appendTabWith(s,dig)
        s = s .. " }"

        lastIsTable = true
      else        
         if(tonumber(e))  then
            s = s .. e
         else
            s = s .. "\"" .. e .. "\""
         end

         lastIsTable = false
      end

      coTemp = coTemp+1     --该table最后一个元素后面不加逗号
      if coTemp<setCo then 
        s = s .. ", "
      end 
	  end

    local set1, set2 = splitFor2Table(set)
    for _k,e in pairs(set1) do execFun(_k,e ) end 
    for _k,e in pairs(set2) do execFun(_k,e ) end 

   if 2==dig then 
      s = s .. "\n" .. "}"
   end 
   return s
end

function Set.tostringNoKey (set) --打印 不带key
   return Set.tostringNoKeyWithDig (set,2)
end
function Set.tostringNoKeyWithDig (set,dig) --打印 不带key
      local s = " { "
      local sep = ""
      for _k,e in pairs(set) do
         -- print(_,e)
         if(type(e)=="table") then
            s = s .. "\n"
            for i=2,dig do
               s = s .. "\t"
            end
            s = s .. ",-T" .. dig .. Set.tostringNoKeyWithDig(e,dig+1)
            s = s .. "\n"
         else
            if(tonumber(e)) then 
               s = s .. sep  .. e
            else
               s = s .. sep  .. "\"" .. e .. "\""
            end
         end
          sep = ", " 
      end
      return s .. "} "
end


function Set.print (s)
   print(Set.tostring(s))
end
function Set.printNotKey (s)
   print(Set.tostringNoKey(s))
end
Set.mt.__add = Set.union
Set.mt.__tostring = Set.tostring

local tablePrint_pt = function (aTable)     --打印无key
   local aNewTable = aTable --Set.new(aTable)
   -- print(aNewTable)
   print(Set.tostringNoKey(aNewTable))
   end

local tablePrint_ptk = function (aTable)    --打印有key
  if not aTable then 
    print("arg____________________is_NIL")
    return nil
  end 
  if not GameConfig.IsOpenLog then return nil end 
   local aNewTable = Set.new(aTable)
   -- print(aNewTable)
   print(Set.tostring(aNewTable))
end

local tablePrint_ut = function (a,b)        --无key 连接两table
   return Set.unionNoKey (a,b) 
end

Declare("tablePrint_pt", tablePrint_pt)
Declare("tablePrint_ptk", tablePrint_ptk)
Declare("tablePrint_ut", tablePrint_ut)

--[[ ======================================= save =======================================]]
local tablePrint = {}
function tablePrint.splitSerialize(str, delimiter)  
    if (delimiter=='') then return false end  
    local pos,arr = 0, {}  
    -- for each divider found  
    for st,sp in function() return string.find(str, delimiter, pos, true) end do  
        table.insert(arr, string.sub(str, pos, st - 1))  
        pos = sp + 1  
    end  
    table.insert(arr, string.sub(str, pos))  
    return arr  
end  
  
function tablePrint.writefile(str, file)  
    os.remove(file);  
    local file=io.open(file,"ab");  
  
    local len = string.len(str);  
    local tbl = tablePrint.splitSerialize(str, "\n");  
    for i = 1, #tbl do  
        file:write(tbl[i].."\n");  
    end  
    file:close();  
end 

function tablePrint.serialize2file(aTable,sFile)    --打印有key
    if not aTable then return nil end
    local aNewTable = Set.new(aTable)
    tablePrint.writefile(Set.tostring(aNewTable),sFile)
end


-- print(type(tt1)=="table")
--[[测试用例
mtt33 = {88,gg = "hh",33}
myt = Set.new{"nor",dpo="jkgt",pg=mtt33,[55] = mtt33,de="jk"}
myt2 = Set.new{ll = "lk",[35] = 26,"rr",df = myt}
newT = myt+myt2
print(newT)
tablePrint_ptk(myt2)
tt1 = {"asdf",[2]=55}
tt2 = {"iuy",[3]=5}
tablePrint_pt(tablePrint_ut(tt1,tt2))


myt = Set.new{"asdf",dpo="jkgt","gg","HH",de="jk"}
myt2 = Set.new{"tt",ll = "lk","ww","rr",df = "ff"}
-- p(myt)
newT = myt+myt2
p(newT)
p(newT[1])
p(newT[2])
p(newT[3])
p(newT[4])
p(newT[5])
]]


--[[ ======================================= 只读表 华丽分割 =======================================]]
--[[
function readOnly (t)
   local proxy = {}
   local mt = {         -- create metatable
       __index = t,
       __newindex = function (t,k,v)
          error("attempt to update a read-only table", 2)
       end
      }
   setmetatable(proxy, mt)
   return proxy
end
]]

-- days = readOnly{"Sunday", "Monday", "Tuesday", "Wednesday",
--        "Thursday", "Friday", "Saturday"}
-- print(days[1])       --> Sunday
-- days[2] = "Noday"



--[[ ======================================= 华丽分割 =======================================]]