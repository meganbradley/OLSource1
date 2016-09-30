---
title: "How to: Instantiate WRL Components Directly"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: 1a9fa011-0cee-4abf-bf83-49adf53ff906
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Instantiate WRL Components Directly
Learn how to use the [!INCLUDE[cppwrl](../vs140/includes/cppwrl_md.md)] ([!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)]) [Microsoft::WRL::Make](../vs140/make-function.md) and [Microsoft::WRL::Details::MakeAndInitialize](../vs140/makeandinitialize-function.md) functions to instantiate a component from the module that defines it.  
  
 By instantiating components directly, you can reduce overhead when you don't need class factories or other mechanisms. You can instantiate a component directly in both [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps and in desktop apps.  
  
 To learn how to use [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)] to create a basic [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] component and instantiate it from an external [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, see [Walkthrough: Creating a Basic Windows Runtime Component Using WRL](../vs140/walkthrough--creating-a-basic-windows-runtime-component-using-wrl.md). To learn how to use [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)] to create a classic COM component and instantiate it from an external desktop app, see [How to: Create a Classic COM Component Using WRL](../vs140/how-to--create-a-classic-com-component-using-wrl.md).  
  
 This document shows two examples. The first example uses the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> function to instantiate a component. The second example uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function to instantiate a component that can fail during construction. (Because COM typically uses <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> values, instead of exceptions, to indicate errors, a COM type typically does not throw from its constructor. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> enables a component to validate its construction arguments through the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method.) Both examples define a basic logger interface and implement that interface by defining a class that writes messages to the console.  
  
> [!IMPORTANT]
>  You can’t use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator to instantiate [!INCLUDE[cppwrl_short](../vs140/includes/cppwrl_short_md.md)] components. Therefore, we recommend that you always use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to instantiate a component directly.  
  
### To create and instantiate a basic logger component  
  
1.  In Visual Studio, create a **Win32 Console Application** project. Name the project, for example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
2.  Add a **Midl File (.idl)** file to the project, name the file <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and then add this code:  
  
     [!code[wrl-logger-make#1](../vs140/codesnippet/CPP/how-to--instantiate-wrl-components-directly_1.idl)]  
  
3.  Use the following code to replace the contents of WRLLogger.cpp.  
  
     [!code[wrl-logger-make#2](../vs140/codesnippet/CPP/how-to--instantiate-wrl-components-directly_2.cpp)]  
  
### To handle construction failure for the basic logger component  
  
1.  Use the following code to replace the definition of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class. This version holds a private string member variable and overrides the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> fails if the call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> fails.  
  
     [!code[wrl-logger-makeandinitialize#1](../vs140/codesnippet/CPP/how-to--instantiate-wrl-components-directly_3.cpp)]  
  
2.  Use the following code to replace the definition of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. This version uses <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to instantiate the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object and checks the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> result.  
  
     [!code[wrl-logger-makeandinitialize#2](../vs140/codesnippet/CPP/how-to--instantiate-wrl-components-directly_4.cpp)]  
  
## See Also  
 [Windows Runtime C++ Template Library (WRL)](../vs140/windows-runtime-c---template-library--wrl-.md)   
 [Microsoft::WRL::Make](../vs140/make-function.md)   
 [Microsoft::WRL::Details::MakeAndInitialize](../vs140/makeandinitialize-function.md)