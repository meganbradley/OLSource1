---
title: "Compiler Error C3705"
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
  - "C3705"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3705"
ms.assetid: 8361017d-5782-4214-a9d7-e9825fd29bc8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3705
'function' : cannot find eventing interface  
  
 You must define an event interface to use COM events. Note that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> lines of the ATL header files shown in the sample below are required for using COM events. To fix this error, uncomment the definition of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface in the sample code.  
  
 The following sample generates C3705:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>