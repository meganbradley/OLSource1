---
title: "bsearch"
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
  - "bsearch"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "bsearch"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "arrays [CRT], binary search"
  - "bsearch function"
ms.assetid: e0ad2f47-e7dd-49ed-8288-870457a14a2c
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bsearch
Performs a binary search of a sorted array. A more secure version of this function is available; see [bsearch_s](../vs140/bsearch_s.md).  
  
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
 Callback function that compares two elements. The first is a pointer to the key for the search and the second is a pointer to the array element to be compared with the key.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns a pointer to an occurrence of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the array pointed to by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not found, the function returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If the array is not in ascending sort order or contains duplicate records with identical keys, the result is unpredictable.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function performs a binary search of a sorted array of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements, each of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> bytes in size. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value is a pointer to the base of the array to be searched, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the value being sought. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter is a pointer to a user-supplied routine that compares the requested key to an array element and returns one of the following values specifying their relationship:  
  
|Value returned by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> routine|Description|  
|-----------------------------------------|-----------------|  
|\< 0|Key is less than array element.|  
|0|Key is equal to array element.|  
|> 0|Key is greater than array element.|  
  
 This function validates its parameters. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and *<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is nonzero, or if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<stdlib.h> and \<search.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program sorts a string array with qsort, and then uses bsearch to find the word "cat".  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **cat cow dog goat horse human pig rat**  
**cat found at 002F0F04**   
## .NET Framework Equivalent  
 [System::Collections::ArrayList::BinarySearch](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.binarysearch.aspx)  
  
## See Also  
 [Searching and Sorting](../vs140/searching-and-sorting.md)   
 [_lfind](../vs140/_lfind.md)   
 [_lsearch](../vs140/_lsearch.md)   
 [qsort](../vs140/qsort.md)