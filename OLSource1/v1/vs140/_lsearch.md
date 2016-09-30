---
title: "_lsearch"
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
  - "_lsearch"
apilocation: 
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_lsearch"
  - "lsearch"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_lsearch function"
  - "values, searching for"
  - "keys, finding in arrays"
  - "arrays [CRT], searching"
  - "linear searches"
  - "searching, linear"
  - "lsearch function"
ms.assetid: 8200f608-159a-46f0-923b-1a37ee1af7e0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lsearch
Performs a linear search for a value; adds to end of list if not found. A more secure version of this function is available; see [_lsearch_s](../vs140/_lsearch_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Object to search for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the base of array to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Width of each array element.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the comparison routine. The first parameter is a pointer to the key for search. The second parameter is a pointer to an array element to be compared with the key.  
  
## Return Value  
 If the key is found, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns a pointer to the element of the array at <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that matches <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If the key is not found, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns a pointer to the newly added item at the end of the array.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function performs a linear search for the value <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in an array of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> bytes. Unlike <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> does not require the array to be sorted. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not found, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> adds it to the end of the array and increments <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument is a pointer to a user-supplied routine that compares two array elements and returns a value specifying their relationship. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> calls the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> routine one or more times during the search, passing pointers to two array elements on each call. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> must compare the elements and return either nonzero (meaning the elements are different) or 0 (meaning the elements are identical).  
  
 This function validates its parameters. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is NULL and *<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is nonzero, or if <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is less than zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<search.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **wordlist before _lsearch: hello thanks bye**  
**wordlist after _lsearch: hello thanks bye extra**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [bsearch](../vs140/bsearch.md)   
 [_lfind](../vs140/_lfind.md)   
 [_lsearch_s](../vs140/_lsearch_s.md)