---
title: "Specifying Levels of Functionality"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObject class, adding functionality to derived classes"
  - "runtime [C++], class information"
  - "serialization [C++], Cobject"
  - "dynamic creation support"
  - "levels [C++], functionality in CObject"
  - "run-time class, information support"
  - "levels [C++]"
ms.assetid: 562669ba-c858-4f66-b5f1-b3beeea4f486
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Specifying Levels of Functionality
This article describes how to add the following levels of functionality to your [CObject](../vs140/cobject-class.md)-derived class:  
  
-   [Run-time class information](#_core_to_add_run.2d.time_class_information)  
  
-   [Dynamic creation support](#_core_to_add_dynamic_creation_support)  
  
-   [Serialization support](#_core_to_add_serialization_support)  
  
 For a general description of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> functionality, see the article [Deriving a Class from CObject](../vs140/deriving-a-class-from-cobject.md).  
  
#### To add run-time class information  
  
1.  Derive your class from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, as described in the [Deriving a Class from CObject](../vs140/deriving-a-class-from-cobject.md) article.  
  
2.  Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro in your class declaration, as shown here:  
  
     [!code[NVC_MFCCObjectSample#2](../vs140/codesnippet/CPP/specifying-levels-of-functionality_1.h)]  
  
3.  Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro in the implementation file (.CPP) of your class. This macro takes as arguments the name of the class and its base class, as follows:  
  
     [!code[NVC_MFCCObjectSample#3](../vs140/codesnippet/CPP/specifying-levels-of-functionality_2.cpp)]  
  
> [!NOTE]
>  Always put <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the implementation file (.CPP) for your class. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macro should be evaluated only once during a compilation and therefore should not be used in an interface file (.H) that could potentially be included in more than one file.  
  
#### To add dynamic creation support  
  
1.  Derive your class from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
2.  Use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> macro in the class declaration.  
  
3.  Define a constructor with no arguments (a default constructor).  
  
4.  Use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> macro in the class implementation file.  
  
#### To add serialization support  
  
1.  Derive your class from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
2.  Override the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member function.  
  
    > [!NOTE]
    >  If you call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directly, that is, you do not want to serialize the object through a polymorphic pointer, omit steps 3 through 5.  
  
3.  Use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> macro in the class declaration.  
  
4.  Define a constructor with no arguments (a default constructor).  
  
5.  Use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> macro in the class implementation file.  
  
> [!NOTE]
>  A "polymorphic pointer" points to an object of a class (call it A) or to an object of any class derived from A (say, B). To serialize through a polymorphic pointer, the framework must determine the run-time class of the object it is serializing (B), since it might be an object of any class derived from some base class (A).  
  
 For more details on how to enable serialization when you derive your class from <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see the articles [Files in MFC](../vs140/files-in-mfc.md) and [Serialization](../vs140/serialization-in-mfc.md).  
  
## See Also  
 [Deriving a Class from CObject](../vs140/deriving-a-class-from-cobject.md)