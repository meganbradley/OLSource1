---
title: "_lfind"
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
  - "_lfind"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "lfind"
  - "_lfind"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "linear searching"
  - "lfind function"
  - "arrays [CRT], searching"
  - "searching, linear"
  - "finding keys in arrays"
  - "_lfind function"
ms.assetid: a40ece70-1674-4b75-94bd-9f57cfff18f2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lfind
Performs a linear search for the specified key. A more secure version of this function is available; see [_lfind_s](../vs140/_lfind_s.md).  
  
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
 Width of array elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to comparison routine. The first parameter is a pointer to key for search. The second parameter is a pointer to array element to be compared with key.  
  
## Return Value  
 If the key is found, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns a pointer to the element of the array at <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that matches <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If the key is not found, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function performs a linear search for the value <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in an array of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes. Unlike <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not require the array to be sorted. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument is a pointer to the base of the array to be searched. The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument is a pointer to a user-supplied routine that compares two array elements and then returns a value specifying their relationship. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> calls the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> routine one or more times during the search, passing pointers to two array elements on each call. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> routine must compare the elements and then return nonzero (meaning the elements are different) or 0 (meaning the elements are identical).  
  
 This function validates its parameters. If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is NULL and *<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is nonzero, or if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is less than zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<search.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Hello found**   
## .NET Framework Equivalent  
 [System::Collections::ArrayList::Contains](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.contains.aspx)  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [_lfind_s](../vs140/_lfind_s.md)   
 [bsearch](../vs140/bsearch.md)   
 [_lsearch](../vs140/_lsearch.md)   
 [qsort](../vs140/qsort.md)