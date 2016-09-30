---
title: "qsort_s"
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
  - "qsort_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "qsort_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "arrays [C++], sorting"
  - "quick-sort algorithm"
  - "qsort_s function"
  - "sorting arrays"
ms.assetid: 6ee817b0-4408-4355-a5d4-6605e419ab91
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# qsort_s
Performs a quick sort. A version of [qsort](../vs140/qsort.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Start of target array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Array size in elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Element size in bytes.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Comparison function. The first argument is the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer. The second argument is a pointer to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for the search. The third argument is a pointer to the array element to be compared with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to a context, which can be any object that the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> routine needs to access.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function implements a quick-sort algorithm to sort an array of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes. The argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a pointer to the base of the array to be sorted. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> overwrites this array with the sorted elements. The argument <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a pointer to a user-supplied routine that compares two array elements and returns a value specifying their relationship. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> calls the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> routine one or more times during the sort, passing pointers to two array elements on each call:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The routine must compare the elements and then return one of the following values:  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> less than <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|0|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> equivalent to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|> 0|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> greater than <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
  
 The array is sorted in increasing order, as defined by the comparison function. To sort an array in decreasing order, reverse the sense of "greater than" and "less than" in the comparison function.  
  
 If invalid parameters are passed to the function, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, then the function returns and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
### Error Conditions  
  
|key|base|compare|num|width|errno|  
|---------|----------|-------------|---------|-----------|-----------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|any|any|any|any|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|any|!= 0|any|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|any|any|any|any|<= 0|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|any|any|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> has the same behavior as <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> but has the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter and sets <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. By passing a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter, comparison functions can use an object pointer to access object functionality or other information not accessible through an element pointer. The addition of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> parameter makes <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>more secure because <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> can be used to avoid reentrancy bugs introduced by using static variables to make shared information available to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> function.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<stdlib.h> and \<search.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
 **Libraries:** All versions of the [CRT Library Features](../vs140/crt-library-features.md).  
  
## Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>function. The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter makes it easier to perform thread-safe sorts. Instead of using static variables that must be synchronized to ensure thread safety, pass a different <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> parameter in each sort. In this example, a locale object is used as the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 \<xref:System.Collections.ArrayList.Sort*>  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [bsearch_s](../vs140/bsearch_s.md)   
 [_lsearch_s](../vs140/_lsearch_s.md)   
 [qsort](../vs140/qsort.md)