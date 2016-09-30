---
title: "Accessing Run-Time Class Information"
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
  - "CObject class, and RTTI"
  - "CObject class, using IsKindOf method"
  - "run time, class information"
  - "RUNTIME_CLASS macro"
  - "CObject class, using RUNTIME_CLASS macro"
  - "RTTI compiler option"
  - "CObject class, accessing run-time class information"
  - "run time"
  - "IsKindOf method method"
  - "run-time class, accessing information"
  - "classes [C++], run-time class information"
  - "run-time class"
  - "RUNTIME_CLASS macro, using"
ms.assetid: 3445a9af-0bd6-4496-95c3-aa59b964570b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessing Run-Time Class Information
This article explains how to access information about the class of an object at run time.  
  
> [!NOTE]
>  MFC does not use the [Run-Time Type Information](../vs140/run-time-type-information.md) (RTTI) support introduced in Visual C++ 4.0.  
  
 If you have derived your class from [CObject](../vs140/cobject-class.md) and used the **DECLARE**_**DYNAMIC** and <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macros explained in the article [Deriving a Class from CObject](../vs140/deriving-a-class-from-cobject.md), the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class has the ability to determine the exact class of an object at run time.  
  
 This ability is most useful when extra type checking of function arguments is needed and when you must write special-purpose code based on the class of an object. However, this practice is not usually recommended because it duplicates the functionality of virtual functions.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to determine if a particular object belongs to a specified class or if it is derived from a specific class. The argument to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, which you can get using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> macro with the name of the class.  
  
### To use the RUNTIME_CLASS macro  
  
1.  Use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with the name of the class, as shown here for the class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>:  
  
     [!code[NVC_MFCCObjectSample#4](../vs140/codesnippet/CPP/accessing-run-time-class-information_1.cpp)]  
  
 You will rarely need to access the run-time class object directly. A more common use is to pass the run-time class object to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function, as shown in the next procedure. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function tests an object to see if it belongs to a particular class.  
  
#### To use the IsKindOf function  
  
1.  Make sure the class has run-time class support. That is, the class must have been derived directly or indirectly from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and used the **DECLARE**_**DYNAMIC** and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> macros explained in the article [Deriving a Class from CObject](../vs140/deriving-a-class-from-cobject.md).  
  
2.  Call the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member function for objects of that class, using the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> macro to generate the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument, as shown here:  
  
     [!code[NVC_MFCCObjectSample#2](../vs140/codesnippet/CPP/accessing-run-time-class-information_2.h)]  
  
     [!code[NVC_MFCCObjectSample#5](../vs140/codesnippet/CPP/accessing-run-time-class-information_3.cpp)]  
  
    > [!NOTE]
    >  IsKindOf returns **TRUE** if the object is a member of the specified class or of a class derived from the specified class. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> does not support multiple inheritance or virtual base classes, although you can use multiple inheritance for your derived Microsoft Foundation classes if necessary.  
  
 One use of run-time class information is in the dynamic creation of objects. This process is discussed in the article [Dynamic Object Creation](../vs140/dynamic-object-creation.md).  
  
 For more detailed information on serialization and run-time class information, see the articles [Files in MFC](../vs140/files-in-mfc.md) and [Serialization](../vs140/serialization-in-mfc.md).  
  
## See Also  
 [Using CObject](../vs140/using-cobject.md)