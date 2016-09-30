---
title: "_lsearch_s"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_lsearch_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_lsearch_s"
  - "lsearch_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "linear searching"
  - "values, searching for"
  - "keys, finding in arrays"
  - "arrays [CRT], searching"
  - "searching, linear"
  - "_lsearch_s function"
  - "lsearch_s function"
ms.assetid: d2db0635-be7a-4799-8660-255f14450882
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lsearch_s
Performs a linear search for a value. A version of [_lsearch](../vs140/_lsearch.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Object to search for.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the base of array to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of elements.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of each array element in bytes.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the comparison routine. The second parameter is a pointer to the key for search. The third parameter is a pointer to an array element to be compared with the key.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to an object that might be accessed in the comparison function.  
  
## Return Value  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is found, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a pointer to the element of the array at <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that matches <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is not found, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns a pointer to the newly added item at the end of the array.  
  
 If invalid parameters are passed to the function, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, then <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|-----------|------------|---------------|-----------|------------|-------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|any|any|any|any|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|any|!= 0|any|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|any|any|any|any|zero|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|any|any|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|an|any|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
## Remarks  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> function performs a linear search for the value <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> in an array of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> bytes. Unlike <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> does not require the array to be sorted. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is not found, then <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> adds it to the end of the array and increments <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function is a pointer to a user-supplied routine that compares two array elements and returns a value specifying their relationship. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> function also takes the pointer to the context as the first argument. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> one or more times during the search, passing pointers to two array elements on each call. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> must compare the elements and then return either nonzero (meaning the elements are different) or 0 (meaning the elements are identical).  
  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> pointer can be useful if the searched data structure is part of an object and the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function needs to access members of the object. For example, code in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> function can cast the void pointer into the appropriate object type and access members of that object. The addition of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> pointer makes <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> more secure because additional context can be used to avoid reentrancy bugs associated with using static variables to make data available to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> function.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<search.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [bsearch_s](../vs140/bsearch_s.md)   
 [_lfind_s](../vs140/_lfind_s.md)   
 [_lsearch](../vs140/_lsearch.md)