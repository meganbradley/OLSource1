---
title: "Searching and Sorting"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.programs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sorting data"
  - "data [CRT], searching"
  - "searching [C++], CRT search functions"
  - "searching [C++]"
ms.assetid: 15e984f0-e155-46f5-8542-51c458792f54
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Searching and Sorting
Use the following functions for searching and sorting.  
  
### Searching and Sorting Functions  
  
|Function|Search or Sort|.NET Framework equivalent|  
|--------------|--------------------|-------------------------------|  
|[bsearch](../vs140/bsearch.md)|Binary search|[System::Collections::ArrayList::BinarySearch](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.binarysearch.aspx)|  
|[bsearch_s](../vs140/bsearch_s.md)|A more secure version of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.|[System::Collections::ArrayList::BinarySearch](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.binarysearch.aspx)|  
|[_lfind](../vs140/_lfind.md)|Linear search for given value|[System::Collections::ArrayList::Contains](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.contains.aspx)|  
|[_lfind_s](../vs140/_lfind_s.md)|A more secure version of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|[System::Collections::ArrayList::Contains](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.contains.aspx)|  
|[_lsearch](../vs140/_lsearch.md)|Linear search for given value, which is added to array if not found|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[_lsearch_s](../vs140/_lsearch_s.md)|A more secure version of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Not applicable. To call the standard C function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[qsort](../vs140/qsort.md)|Quick sort|[System::Collections::ArrayList::Sort](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.sort.aspx)|  
|[qsort_s](../vs140/qsort_s.md)|A more secure version of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|[System::Collections::ArrayList::Sort](https://msdn.microsoft.com/en-us/library/system.collections.arraylist.sort.aspx)|  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)