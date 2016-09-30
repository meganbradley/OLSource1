---
title: "Compiler Error C3856"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3856"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3856"
ms.assetid: 242d9322-c325-4f20-be58-b2be6da56d60
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3856
'type': class is not a class type  
  
 The most common cause for this error is when there are more generic or template parameter lists at the point of definition than there were at the point of declaration.  
  
 The following sample generates C3856:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C3856 can also occur when using generics:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>