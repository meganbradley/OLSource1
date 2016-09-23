---
title: "Using CObject"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CObject
dev_langs: 
  - C++
helpviewer_keywords: 
  - examples [MFC], CObject
  - root base class for MFC
  - derived classes, from CObject
  - MFC, base class
  - CObject class
ms.assetid: d0cd19bb-2856-4b41-abbc-620fd64cb223
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Using CObject
[CObject](../vs140/cobject-class.md) is the root base class for most of the Microsoft Foundation Class Library (MFC). The `CObject` class contains many useful features that you may want to incorporate into your own program objects, including serialization support, run-time class information, and object diagnostic output. If you derive your class from `CObject`, your class can exploit these `CObject` features.  
  
## What do you want to do?  
  
-   [Derive a class from CObject](../vs140/deriving-a-class-from-cobject.md)  
  
-   [Add support for run-time class information, dynamic creation, and serialization to my derived class](../vs140/specifying-levels-of-functionality.md)  
  
-   [Access run-time class information](../vs140/accessing-run-time-class-information.md)  
  
-   [Create objects dynamically](../vs140/dynamic-object-creation.md)  
  
-   [Dump the object's data for diagnostic purposes](assetId:///727855b1-5a83-44bd-9fe3-f1d535584b59)  
  
-   Validate the object's internal state (see [MFC ASSERT_VALID and CObject::AssertValid](assetId:///7654fb75-9e9a-499a-8165-0a96faf2d5e6))  
  
-   [Have the class serialize itself to persistent storage](../vs140/serialization-in-mfc.md)  
  
-   See a list of [CObject Frequently Asked Questions](../vs140/cobject-class--frequently-asked-questions.md)  
  
## See Also  
 [Concepts](../vs140/mfc-concepts.md)   
 [General MFC Topics](../vs140/general-mfc-topics.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)   
 [Files](../vs140/files-in-mfc.md)   
 [Serialization](../vs140/serialization-in-mfc.md)