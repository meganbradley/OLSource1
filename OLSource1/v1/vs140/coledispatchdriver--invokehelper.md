---
title: "COleDispatchDriver::InvokeHelper"
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
  - "VARENUM"
  - "COleDispatchDriver.InvokeHelper"
  - "COleDispatchDriver::InvokeHelper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class, operations"
  - "InvokeHelper method"
  - "VARENUM"
ms.assetid: fba94ba7-52a4-4c7f-980e-f606d5834403
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::InvokeHelper
Calls the object method or property specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, in the context specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Identifies the method or property to be invoked.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Flags describing the context of the call to **IDispatch::Invoke**. . For a list of possible values, see the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter in  [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the type of the return value. For possible values, see the Remarks section.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Address of the variable that will receive the property value or return value. It must match the type specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string of bytes specifying the types of the parameters following <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 *...*  
 Variable list of parameters, of types specified in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter specifies the types of the parameters passed to the method or property. The variable list of arguments is represented by **...** in the syntax declaration.  
  
 Possible values for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument are taken from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> enumeration. Possible values are as follows:  
  
|Symbol|Return Type|  
|------------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|**double**|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|**DATE**|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|**VT_DISPATCH**|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|**BOOL**|  
|**VT_VARIANT**|**VARIANT**|  
|**VT_UNKNOWN**|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> argument is a space-separated list of **VTS_** constants. One or more of these values, separated by spaces (not commas), specifies the function's parameter list. Possible values are listed with the [EVENT_CUSTOM](../vs140/event_custom.md) macro.  
  
 This function converts the parameters to **VARIANTARG** values, then invokes the [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx) method. If the call to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> fails, this function will throw an exception. If the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> (status code) returned by **IDispatch::Invoke** is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, this function throws a [COleException](../vs140/coleexception-class.md) object; otherwise it throws a [COleDispatchException](../vs140/coledispatchexception-class.md).  
  
 For more information, see [VARIANTARG](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [Implementing the IDispatch Interface](http://msdn.microsoft.com/library/windows/desktop/ms221037\(v=vs.85\).aspx), [IDispatch::Invoke](http://msdn.microsoft.com/library/windows/desktop/ms221479\(v=vs.85\).aspx), and [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [COleDispatchDriver::CreateDispatch](../vs140/coledispatchdriver--createdispatch.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleException Class](../vs140/coleexception-class.md)   
 [COleDispatchException Class](../vs140/coledispatchexception-class.md)