---
title: "Deriving a Class from CObject"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_DYNCREATE macro"
  - "DECLARE_SERIAL macro"
  - "macros [C++], serialization"
  - "serialization [C++], macros"
  - "DECLARE_DYNAMIC macro"
  - "derived classes, from CObject"
  - "CObject class, deriving serializable classes"
  - "CObject class, deriving from"
ms.assetid: 5ea4ea41-08b5-4bd8-b247-c5de8c152a27
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Deriving a Class from CObject
This article describes the minimum steps necessary to derive a class from [CObject](../VS_csharp/cobject-class.md). Other `CObject` class articles describe the steps needed to take advantage of specific `CObject` features, such as serialization and diagnostic debugging support.  
  
 In the discussions of `CObject`, the terms "interface file" and "implementation file" are used frequently. The interface file (often called the header file, or .H file) contains the class declaration and any other information needed to use the class. The implementation file (or .CPP file) contains the class definition as well as the code that implements the class member functions. For example, for a class named `CPerson`, you would typically create an interface file named PERSON.H and an implementation file named PERSON.CPP. However, for some small classes that will not be shared among applications, it is sometimes easier to combine the interface and implementation into a single .CPP file.  
  
 You can choose from four levels of functionality when deriving a class from `CObject`:  
  
-   Basic functionality: No support for run-time class information or serialization but includes diagnostic memory management.  
  
-   Basic functionality plus support for run-time class information.  
  
-   Basic functionality plus support for run-time class information and dynamic creation.  
  
-   Basic functionality plus support for run-time class information, dynamic creation, and serialization.  
  
 Classes designed for reuse (those that will later serve as base classes) should at least include run-time class support and serialization support, if any future serialization need is anticipated.  
  
 You choose the level of functionality by using specific declaration and implementation macros in the declaration and implementation of the classes you derive from `CObject`.  
  
 The following table shows the relationship among the macros used to support serialization and run-time information.  
  
### Macros Used for Serialization and Run-Time Information  
  
|Macro used|CObject::IsKindOf|CRuntimeClass::<br /><br /> CreateObject|CArchive::operator>><br /><br /> CArchive::operator<<|  
|----------------|-----------------------|--------------------------------------|-------------------------------------------------------|  
|Basic `CObject` functionality|No|No|No|  
|`DECLARE_DYNAMIC`|Yes|No|No|  
|`DECLARE_DYNCREATE`|Yes|Yes|No|  
|`DECLARE_SERIAL`|Yes|Yes|Yes|  
  
#### To use basic CObject functionality  
  
1.  Use the normal C++ syntax to derive your class from `CObject` (or from a class derived from `CObject`).  
  
     The following example shows the simplest case, the derivation of a class from `CObject`:  
  
     [!code[NVC_MFCCObjectSample#1](../VS_csharp/codesnippet/CPP/deriving-a-class-from-cobject_1.h)]  
  
 Normally, however, you may want to override some of `CObject`'s member functions to handle the specifics of your new class. For example, you may usually want to override the `Dump` function of `CObject` to provide debugging output for the contents of your class. For details on how to override `Dump`, see the article [Diagnostics: Dumping Object Contents](assetId:///727855b1-5a83-44bd-9fe3-f1d535584b59). You may also want to override the `AssertValid` function of `CObject` to provide customized testing to validate the consistency of the data members of class objects. For a description of how to override `AssertValid`, see [MFC ASSERT_VALID and CObject::AssertValid](assetId:///7654fb75-9e9a-499a-8165-0a96faf2d5e6).  
  
 The article [Specifying Levels of Functionality](../VS_csharp/specifying-levels-of-functionality.md) describes how to specify other levels of functionality, including run-time class information, dynamic object creation, and serialization.  
  
## See Also  
 [Using CObject](../VS_csharp/using-cobject.md)