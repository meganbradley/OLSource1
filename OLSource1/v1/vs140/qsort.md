---
title: "qsort"
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
  - "qsort"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "qsort"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "qsort function"
  - "quick-sort algorithm"
  - "sorting arrays"
  - "arrays [CRT], sorting"
ms.assetid: d6cb33eb-d209-485f-8d41-229eb743c027
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# qsort
Performs a quick sort. A more secure version of this function is available; see [qsort_s](../vs140/qsort_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Start of target array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Array size in elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Element size in bytes.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to a user-supplied routine that compares two array elements and returns a value that specifies their relationship.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function implements a quick-sort algorithm to sort an array of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bytes. The argument <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a pointer to the base of the array to be sorted. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> overwrites this array by using the sorted elements.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> calls the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> routine one or more times during the sort, and passes pointers to two array elements on each call.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The routine compares the elements and returns one of the following values.  
  
|Compare function return value|Description|  
|-----------------------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> less than <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|0|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> equivalent to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|> 0|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> greater than <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
  
 The array is sorted in increasing order, as defined by the comparison function. To sort an array in decreasing order, reverse the sense of "greater than" and "less than" in the comparison function.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and *<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is nonzero, or if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is less than zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<stdlib.h> and \<search.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **boy deserves every favor good**   
## .NET Framework Equivalent  
 [System::Collections::ArrayList::Sort](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.sort.aspx)  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [bsearch](../vs140/bsearch.md)   
 [_lsearch](../vs140/_lsearch.md)