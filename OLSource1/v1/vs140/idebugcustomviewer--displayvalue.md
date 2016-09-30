---
title: "IDebugCustomViewer::DisplayValue"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugCustomViewer::DisplayValue"
helpviewer_keywords: 
  - "IDebugCustomViewer::DisplayValue"
ms.assetid: 7a538248-5ced-450e-97cd-13fabe35fb1c
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomViewer::DisplayValue
This method is called to display the specified value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Parent window  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] ID for custom viewers that support more than one type.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Reserved. Always set to null.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Interface that can be used to retrieve the value to be displayed.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise returns error code.  
  
## Remarks  
 The display is "modal" in that this method will create the necessary window, display the value, wait for input, and close the window, all before returning to the caller. This means the method must handle all aspects of displaying the property's value, from creating a window for output, to waiting for user input, to destroying the window.  
  
 To support changing the value on the given [IDebugProperty3](../vs140/idebugproperty3.md) object, you can use the [IDebugProperty3::SetValueAsStringWithError](../vs140/idebugproperty3--setvalueasstringwitherror.md) method —if the value can be expressed as a string. Otherwise, it is necessary to create a custom interface—exclusive to the expression evaluator implementing this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method—on the same object that implements the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface. This custom interface would supply methods for changing the data of an arbitrary size or complexity.  
  
## See Also  
 [IDebugCustomViewer](../vs140/idebugcustomviewer.md)   
 [IDebugProperty3](../vs140/idebugproperty3.md)   
 [IDebugProperty3::SetValueAsStringWithError](../vs140/idebugproperty3--setvalueasstringwitherror.md)