---
title: "Aggregates and Unions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregates [C++], and unions"
ms.assetid: 859fc211-b111-4f12-af98-de78e48f9b92
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Aggregates and Unions
Other types such as arrays, structs, and unions have stricter alignment requirements that ensure consistent aggregate and union storage and data retrieval. Here are the definitions for array, structure, and union:  
  
 Array  
 Contains an ordered group of adjacent data objects. Each object is called an element. All elements within an array have the same size and data type.  
  
 Structure  
 Contains an ordered group of data objects. Unlike the elements of an array, the data objects within a structure can have different data types and sizes. Each data object in a structure is called a member.  
  
 Union  
 An object that holds any one of a set of named members. The members of the named set can be of any type. The storage allocated for a union is equal to the storage required for the largest member of that union, plus any padding required for alignment.  
  
 The following table shows the strongly suggested alignment for the scalar members of unions and structures.  
  
||||  
|-|-|-|  
|Scalar Type|C Data Type|Required Alignment|  
|**INT8**|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Byte|  
|**UINT8**|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Byte|  
|**INT16**|**short**|Word|  
|**UINT16**|**unsigned short**|Word|  
|**INT32**|**int, long**|Doubleword|  
|**UINT32**|**unsigned int, unsigned long**|Doubleword|  
|**INT64**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Quadword|  
|**UINT64**|**unsigned __int64**|Quadword|  
|**FP32 (single precision)**|**float**|Doubleword|  
|**FP64 (double precision)**|**double**|Quadword|  
|**POINTER**|**\***|Quadword|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|**struct __m64**|Quadword|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|**struct __m128**|Octaword|  
  
 The following aggregate alignment rules apply:  
  
-   The alignment of an array is the same as the alignment of one of the elements of the array.  
  
-   The alignment of the beginning of a structure or a union is the maximum alignment of any individual member. Each member within the structure or union must be placed at its proper alignment as defined in the previous table, which may require implicit internal padding, depending on the previous member.  
  
-   Structure size must be an integral multiple of its alignment, which may require padding after the last member. Since structures and unions can be grouped in arrays, each array element of a structure or union must begin and end at the proper alignment previously determined.  
  
-   It is possible to align data in such a way as to be greater than the alignment requirements as long as the previous rules are maintained.  
  
-   An individual compiler may adjust the packing of a structure for size reasons. For example [/Zp (Struct Member Alignment)](../vs140/-zp--struct-member-alignment-.md) allows for adjusting the packing of structures.  
  
## See Also  
 [Types and Storage](../vs140/types-and-storage.md)