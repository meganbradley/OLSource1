---
title: "AsyncBase::FireCompletion Method"
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
  - "async/Microsoft::WRL::AsyncBase::FireCompletion"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireCompletion method"
ms.assetid: b5e29d6d-52e7-4148-a7f3-a313b1359819
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsyncBase::FireCompletion Method
Invokes the completion event handler, or resets the internal progress delegate.  
  
## Syntax  
  
```  
void FireCompletion(  
   void  
) override;  
  
virtual void FireCompletion();  
```  
  
## Remarks  
 The first version of FireCompletion() resets the internal progress delegate variable. The second version invokes the completion event handler if the asynchronous operation is complete.  
  
## Requirements  
 **Header:** async.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [AsyncBase Class](../vs140/asyncbase-class.md)