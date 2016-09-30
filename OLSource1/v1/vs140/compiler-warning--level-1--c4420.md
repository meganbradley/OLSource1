---
title: "Compiler Warning (level 1) C4420"
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
  - "C4420"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4420"
ms.assetid: 44a37754-7ddd-4764-a5f7-d33e05c20091
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4420
'operator' : operator not available, using 'operator' instead; run-time checking may be compromised  
  
 This warning is generated when you use the [/RTCv](../vs140/-rtc--run-time-error-checks-.md) (vector new/delete checking) and when no vector form is found. In this case, the non-vector form is used.  
  
 In order for /RTCv to work correctly, the compiler should always call the vector form of [new](../vs140/new-operator--c---.md)/[delete](../vs140/delete-operator--c---.md) if the vector syntax was used.