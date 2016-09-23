---
title: "Fatal Error C1107"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C1107
dev_langs: 
  - C++
helpviewer_keywords: 
  - C1107
ms.assetid: 541a4d9f-10bc-4dd8-b68e-15e548f3dc0a
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Fatal Error C1107
could not find assembly 'file': please specify the assembly search path using /AI or by setting the LIBPATH environment variable  
  
 A metadata file was passed to a [#using](../vs140/sharpusing-directive--c---.md) directive that the compiler was unable to locate.  
  
 LIBPATH, which is described in the topic for `#using`, and the [/AI](../vs140/-ai--specify-metadata-directories-.md) compiler option allow you to specify directories in which the compiler will look for referenced metadata files.