---
title: "Compiler Error C3138"
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
  - "C3138"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3138"
ms.assetid: 364ee9e8-9358-410e-bd35-9c4a226a3753
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3138
'interface' : a 'attribute' interface must inherit from IDispatch, or from an interface that inherits from IDispatch  
  
 An interface with the [dual](../vs140/dual.md) or [dispinterface](../vs140/dispinterface.md) attributes does not have <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> as a direct or indirect base interface.  
  
 The following example generates C3138:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>