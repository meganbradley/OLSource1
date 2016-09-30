---
title: "Compiler Error C3918"
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
  - "C3918"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3918"
ms.assetid: a8b3a90a-3fe1-4244-a5ff-a31cdae97d98
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3918
usage requires 'member' to be a data member  
  
 C3918 can occur for several reasons related to events.  
  
## Example  
 C3918 can occur because a class member is required in the current context. The following sample generates C3918.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C3918 is also caused if you try to check a trivial event for null (the event name will no longer provide direct access to the backing store delegate for the event).  
  
 The following sample generates C3918.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 C3918 can also occur if you incorrectly subscribe to an event. The following sample generates C3918.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>