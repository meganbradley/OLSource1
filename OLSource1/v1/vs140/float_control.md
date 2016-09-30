---
title: "float_control"
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
  - "vc-pragma.float_control"
  - "float_control_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "float_control pragma"
  - "pragmas, float_control"
ms.assetid: 4f4ba5cf-3707-413e-927d-5ecdbc0a9a43
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# float_control
Specifies floating-point behavior for a function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Flags  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> *,* <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **[push]**  
 Specifies floating-point behavior. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be **precise** or **except**. For more information, see [/fp (Specify Floating-Point Behavior)](../vs140/-fp--specify-floating-point-behavior-.md). <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can either be **on** or **off**.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **precise**, the settings for **precise** and **except** are being specified. **except** can only be set to **on** when **precise** is also set to **on**.  
  
 If the optional **push** token is added, the current setting for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is pushed on to the internal compiler stack.  
  
 **push**  
 Push the current <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> setting on to the internal compiler stack  
  
 **pop**  
 Removes the<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> setting from the top of the internal compiler stack and makes that the new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> setting.  
  
## Remarks  
 You cannot turn <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> off when **except** is on. Similarly, **precise** cannot be turned off when <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is on. To go from strict model to a fast model with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> pragma, use the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To go from fast model to a strict model with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pragma, use the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Other floating-point pragmas include:  
  
-   [fenv_access](../vs140/fenv_access.md)  
  
-   [fp_contract](../vs140/fp_contract.md)  
  
## Example  
 The following sample shows how to catch an overflow floating-point exception by using pragma <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Pass**   
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)