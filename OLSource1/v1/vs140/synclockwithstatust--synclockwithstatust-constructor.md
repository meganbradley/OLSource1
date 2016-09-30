---
title: "SyncLockWithStatusT::SyncLockWithStatusT Constructor"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Details::SyncLockWithStatusT::SyncLockWithStatusT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SyncLockWithStatusT, constructor"
ms.assetid: 5d2fb820-ae1b-495f-8084-ebb4fecc3104
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SyncLockWithStatusT::SyncLockWithStatusT Constructor
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An rvalue-reference to another SyncLockWithStatusT object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to another SyncLockWithStatusT object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of the [status_](../vs140/synclockwithstatust--status_-data-member.md) data member of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter or the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
## Remarks  
 Initializes a new instance of the SyncLockWithStatusT class.  
  
 The first constructor initializes the current SyncLockWithStatusT object from another SyncLockWithStatusT specified by parameter <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and then invalidates the other SyncLockWithStatusT object. The second constructor is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and initializes the current SyncLockWithStatusT object to an invalid state.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::Details  
  
## See Also  
 [SyncLockWithStatusT Class](../vs140/synclockwithstatust-class.md)   
 [SyncLockWithStatusT::GetStatus Method](../vs140/synclockwithstatust--getstatus-method.md)