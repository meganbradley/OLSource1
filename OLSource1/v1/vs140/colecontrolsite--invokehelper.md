---
title: "COleControlSite::InvokeHelper"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "COleControlSite::InvokeHelper"
  - "COleControlSite.InvokeHelper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "InvokeHelper method"
ms.assetid: 12919494-da80-4a23-95fa-8f9b55616918
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::InvokeHelper
Invokes the method or property specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, in the context specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Identifies the dispatch ID of the property or method, found on the control's <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface, to be invoked.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Flags describing the context of the call to IDispatch::Invoke. For possible <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values, see <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the type of the return value. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Address of the variable that will receive the property value or return value. It must match the type specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 *...*  
 Variable list of parameters, of types specified in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by ... in the syntax declaration.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the **IDispatch::Invoke** method on the control. If the call to **IDispatch::Invoke** fails, this function will throw an exception. If the status code returned by **IDispatch::Invoke** is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, this function throws a **COleDispatchException** object, otherwise it throws a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)