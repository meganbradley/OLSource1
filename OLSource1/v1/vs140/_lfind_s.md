---
title: "_lfind_s"
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
  - "_lfind_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "lfind_s"
  - "_lfind_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "linear searching"
  - "keys, finding in arrays"
  - "lfind_s function"
  - "arrays [CRT], searching"
  - "searching, linear"
  - "_lfind_s function"
ms.assetid: f1d9581d-5c9d-4222-a31c-a6dfafefa40d
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lfind_s
Performs a linear search for the specified key. A version of [_lfind](../vs140/_lfind.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Object to search for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the base of search data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of array elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size of array elements in bytes.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to comparison routine. The first parameter is the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer. The second parameter is a pointer to key for search. The third parameter is a pointer to array element to be compared with key.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to an object that might be accessed in the comparison function.  
  
## Return Value  
 If the key is found, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns a pointer to the element of the array at <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that matches <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the key is not found, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 If invalid parameters are passed to the function, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Error Conditions  
  
|key|base|compare|num|size|errno|  
|---------|----------|-------------|---------|----------|-----------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|any|any|any|any|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|any|!= 0|any|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|any|any|any|any|zero|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|any|any|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|an|any|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function performs a linear search for the value <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in an array of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> bytes. Unlike <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> does not require the array to be sorted. The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument is a pointer to the base of the array to be searched. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> argument is a pointer to a user-supplied routine that compares two array elements and then returns a value specifying their relationship. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> calls the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> routine one or more times during the search, passing the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> pointer and pointers to two array elements on each call. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> routine must compare the elements then return nonzero (meaning that the elements are different) or 0 (meaning the elements are identical).  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is similar to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> except for the addition of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> pointer to the arguments of the comparison function and the parameter list of the function. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> pointer can be useful if the searched data structure is part of an object and the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function needs to access members of the object. The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> function can cast the void pointer into the appropriate object type and access members of that object. The addition of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter makes <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> more secure because additional context can be used to avoid reentrancy bugs associated with using static variables to make data available to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<search.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **weit found**   
## .NET Framework Equivalent  
 \<xref:System.Collections.ArrayList.Contains*>  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [bsearch_s](../vs140/bsearch_s.md)   
 [_lsearch_s](../vs140/_lsearch_s.md)   
 [qsort_s](../vs140/qsort_s.md)   
 [_lfind](../vs140/_lfind.md)