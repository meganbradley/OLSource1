---
title: "INTERFACE_PART"
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
  - "AFXWIN/INTERFACE_PART"
  - "INTERFACE_PART"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INTERFACE_PART macro"
ms.assetid: 3a213520-e82c-45a2-96e2-3894ac8defeb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# INTERFACE_PART
Used between the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro and the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro for each interface your object will support.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the class that contains the interface map.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The IID that is to be mapped to the embedded class.  
  
 *localClass*  
 The name of the local class.  
  
## Remarks  
 It allows you to map an IID to a member of the class indicated by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and *localClass*.  
  
 For more information on interface maps, see [Technical Note 38](../vs140/tn038--mfc-ole-iunknown-implementation.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_INTERFACE_MAP](../vs140/begin_interface_map.md)   
 [END_MESSAGE_MAP](../vs140/end_message_map.md)