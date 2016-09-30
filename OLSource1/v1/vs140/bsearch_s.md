---
title: "bsearch_s"
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
  - "bsearch_s"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "bsearch_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "arrays [CRT], binary search"
  - "bsearch_s function"
ms.assetid: d5690d5e-6be3-4f1d-aa0b-5ca6dbded276
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bsearch_s
Performs a binary search of a sorted array. This is version of [bsearch](../vs140/bsearch.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Object to search for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to base of search data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Width of elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Callback function that compares two elements. The first argument is the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer. The second argument is a pointer to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for the search. The third argument is a pointer to the array element to be compared with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to an object that can be accessed in the comparison function.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns a pointer to an occurrence of<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the array pointed to by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not found, the function returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If the array is not in ascending sort order or contains duplicate records with identical keys, the result is unpredictable.  
  
 If invalid parameters are passed to the function, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
### Error Conditions  
  
|||||||  
|-|-|-|-|-|-|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|any|any|any|any|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|any|!= 0|any|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|any|any|any|any|= 0|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|any|any|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|an|any|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Remarks  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function performs a binary search of a sorted array of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> bytes in size. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> value is a pointer to the base of the array to be searched, and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is the value being sought. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter is a pointer to a user-supplied routine that compares the requested key to an array element and returns one of the following values specifying their relationship:  
  
|Value returned by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> routine|Description|  
|-----------------------------------------|-----------------|  
|\< 0|Key is less than array element.|  
|0|Key is equal to array element.|  
|> 0|Key is greater than array element.|  
  
 The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> pointer may be useful if the searched data structure is part of an object, and the compare function needs to access members of the object. The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function may cast the void pointer into the appropriate object type and access members of that object. The addition of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter makes <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> more secure since additional context may be used to avoid reentrancy bugs associated with using static variables to make data available to the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<stdlib.h> and \<search.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program sorts a string array with [qsort_s](../vs140/qsort_s.md), and then uses bsearch_s to find the word "cat".  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **cat cow dog goat horse human pig rat**  
**cat found at 002F0F04**   
## .NET Framework Equivalent  
 \<xref:System.Collections.ArrayList.BinarySearch*>  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [_lfind](../vs140/_lfind.md)   
 [_lsearch](../vs140/_lsearch.md)   
 [qsort](../vs140/qsort.md)