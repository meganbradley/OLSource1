---
title: "How to: Load Unmanaged Resources into a Byte Array"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "native resources, loading into Byte array"
  - "unmanaged resources, loading into Byte array"
  - "native resources"
ms.assetid: cdada6cd-6d42-437a-a90f-44a0b18d6a93
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Load Unmanaged Resources into a Byte Array
This topic discusses several ways to load unmanaged resources into a \<xref:System.Byte*> array.  
  
## Example  
 If you know the size of your unmanaged resource, you can preallocate a CLR array and then load the resource into the array using a pointer to the array block of the CLR array.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **0123456789**   
## Example  
 This sample shows how to copy data from an unmanaged memory block to a managed array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)