---
title: "CTypedPtrMap Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CTypedPtrMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "type-safe collections"
  - "template classes, CTypedPtrMap class"
  - "maps"
  - "CTypedPtrMap class"
  - "pointer maps"
ms.assetid: 9f377385-c6e9-4471-8b40-8fe220c50164
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrMap Class
Provides a type-safe "wrapper" for objects of the pointer-map classes <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Base class of the typed pointer map class; must be a pointer map class ( <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Class of the object used as the key to the map.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Class of the object stored in the map.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTypedPtrMap::GetNextAssoc](#ctypedptrmap__getnextassoc)|Gets the next element for iterating.|  
|[CTypedPtrMap::Lookup](#ctypedptrmap__lookup)|Returns a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> based on a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|[CTypedPtrMap::RemoveKey](#ctypedptrmap__removekey)|Removes an element specified by a key.|  
|[CTypedPtrMap::SetAt](#ctypedptrmap__setat)|Inserts an element into the map; replaces an existing element if a matching key is found.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CTypedPtrMap::operator &#91;&#93;](#ctypedptrmap__operator_at)|Inserts an element into the map.|  
  
## Remarks  
 When you use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the C++ type-checking facility helps eliminate errors caused by mismatched pointer types.  
  
 Because all <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> functions are inline, use of this template does not significantly affect the size or speed of your code.  
  
 For more information on using <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, see the articles [Collections](../vs140/collections.md) and [Template-Based Classes](../vs140/template-based-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxtempl.h  
  
##  \<a name="ctypedptrmap__getnextassoc">\</a>  CTypedPtrMap::GetNextAssoc  
 Retrieves the map element at <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, then updates <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to refer to the next element in the map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies a reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>**::GetStartPosition** call.  
  
 *KEY*  
 Template parameter specifying the type of the map's keys.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the returned key of the retrieved element.  
  
 *VALUE*  
 Template parameter specifying the type of the map's values.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Specifies the returned value of the retrieved element.  
  
### Remarks  
 This function is most useful for iterating through all the elements in the map. Note that the position sequence is not necessarily the same as the key value sequence.  
  
 If the retrieved element is the last in the map, then the new value of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is set to **NULL**.  
  
 This inline function calls <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>**::GetNextAssoc**.  
  
##  \<a name="ctypedptrmap__lookup">\</a>  CTypedPtrMap::Lookup  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> uses a hashing algorithm to quickly find the map element with a key that matches exactly.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Template parameter specifying the base class of this map's class.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The key of the element to be looked up.  
  
 *VALUE*  
 Template parameter specifying the type of values stored in this map.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies the returned value of the retrieved element.  
  
### Return Value  
 Nonzero if the element was found; otherwise 0.  
  
### Remarks  
 This inline function calls <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>**::Lookup**.  
  
##  \<a name="ctypedptrmap__operator_at">\</a>  CTypedPtrMap::operator [ ]  
 This operator can be used only on the left side of an assignment statement (an l-value).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *VALUE*  
 Template parameter specifying the type of values stored in this map.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Template parameter specifying the base class of this map's class.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The key of the element to be looked up or created in the map.  
  
### Remarks  
 If there is no map element with the specified key, then a new element is created. There is no "right side" (r-value) equivalent to this operator because there is a possibility that a key may not be found in the map. Use the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> member function for element retrieval.  
  
##  \<a name="ctypedptrmap__removekey">\</a>  CTypedPtrMap::RemoveKey  
 This member function calls <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>**::RemoveKey**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *KEY*  
 Template parameter specifying the type of the map's keys.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Key for the element to be removed.  
  
### Return Value  
 Nonzero if the entry was found and successfully removed; otherwise 0.  
  
### Remarks  
 For more detailed remarks, see [CMapStringToOb::RemoveKey](../vs140/cmapstringtoob-class.md#cmapstringtoob__removekey).  
  
##  \<a name="ctypedptrmap__setat">\</a>  CTypedPtrMap::SetAt  
 This member function calls <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>**::SetAt**.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *KEY*  
 Template parameter specifying the type of the map's keys.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Specifies the key value of the newValue.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies the object pointer that is the value of the new element.  
  
### Remarks  
 For more detailed remarks, see [CMapStringToOb::SetAt](../vs140/cmapstringtoob-class.md#cmapstringtoob__setat).  
  
## See Also  
 [MFC Sample COLLECT](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMapPtrToPtr](../vs140/cmapptrtoptr-class.md)   
 [CMapPtrToWord](../vs140/cmapptrtoword-class.md)   
 [CMapWordToPtr](../vs140/cmapwordtoptr-class.md)   
 [CMapStringToPtr](../vs140/cmapstringtoptr-class.md)