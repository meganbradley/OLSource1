---
title: "SyncLockT::SyncLockT Constructor"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Details::SyncLockT::SyncLockT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SyncLockT, constructor"
ms.assetid: 713dfd9f-7369-4d86-b4a0-8b32c184d89b
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SyncLockT::SyncLockT Constructor
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An rvalue-reference to another SyncLockT object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to another SyncLockWithStatusT object.  
  
## Remarks  
 Initializes a new instance of the SyncLockT class.  
  
 The first constructor initializes the current SyncLockT object from another SyncLockT object specified by parameter <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and then invalidates the other SyncLockT object. The second constructor is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and initializes the current SyncLockT object to an invalid state.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::Details  
  
## See Also  
 [SyncLockT Class](../vs140/synclockt-class.md)