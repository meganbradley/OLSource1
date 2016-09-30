---
title: "DiaAddressMapEntry"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DiaAddressMapEntry enumeration"
ms.assetid: 5d0ae226-981d-4541-a801-fc4993fe663b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DiaAddressMapEntry
Describes an entry in an address map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A relative virtual address (RVA) in image A.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The relative virtual address <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is mapped to in image B.  
  
## Remarks  
 An address map provides a translation from one image layout (A) to another (B). An array of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structures sorted by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> defines an address map.  
  
 To translate an address, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, in image A to an address, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, in image B, perform the following steps:  
  
1.  Search the map for the entry, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, with the largest <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> less than or equal to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
2.  Set <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
3.  Set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 An array of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structures is passed to the [IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md) method.  
  
## Requirements  
 Header: dia2.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md)