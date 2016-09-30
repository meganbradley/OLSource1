---
title: "OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO macro"
ms.assetid: abdc093c-6502-42de-8419-b7ebf45299d1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OBJECT_ENTRY_NON_CREATEABLE_EX_AUTO
Allows you to specify that the object should be registered and initialized, but it should not be externally creatable via <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The CLSID of a COM class implemented by the C++ class named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The name of the C++ class implementing the COM class represented by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Object entry macros are placed at global scope in the project to provide support for the registration, initialization, and creation of a class.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> allows you to specify that an object should be registered and initialized (see [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md) for more information), but it should not be creatable via <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Object Map Macros](../vs140/object-map-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [OBJECT_ENTRY_AUTO](../vs140/object_entry_auto.md)