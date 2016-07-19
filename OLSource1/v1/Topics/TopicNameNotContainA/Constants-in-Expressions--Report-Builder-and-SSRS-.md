---
title: Constants in Expressions (Report Builder and SSRS)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b8ae650b-0f46-4848-b62b-15f8a40751b8
manager: mblythe
---
# Constants in Expressions (Report Builder and SSRS)
A constant consists of literal text or predefined text. The report processor has access to predefined constants so that when you include them in an expression, the values they represent are substituted in the expression before it is evaluated.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Literal Text  
 In an expression, literal text is text that is in double quotation marks. You can also type text directly into a text box without double quotation marks if it is not part of an expression. If the text box value does not begin with an equal sign (=), the text is treated as literal text. The following table shows several examples of literal text in an expression.  
  
|Constant|Display text|Expression text|  
|--------------|------------------|---------------------|  
|Report run at:|<<Expr\>>|`="Report run at: " & Globals!ExecutionTime`|  
|Adventure Works Cycles|Adventure Works Cycles|Adventure Works Cycles|  
|[Bracketed display text]|\\[Bracketed display text\\]|[Bracketed display text]|  
  
## RDL Constants  
 You can use constants defined in Report Definition Language (RDL) in an expression. In the **Expression** dialog box, constants appear when you create an expression for a report property that only accepts certain valid values, also known as enumerated types. The following table shows two examples.  
  
|Property|Description|Values|  
|--------------|-----------------|------------|  
|TextAlign|Valid values for aligning text in a text box.|General, Left, Center, Right|  
|BorderStyle|Valid values for a line added to a report.|Default, None, Dotted, Dashed, Solid, Double, DashDot, DashDotdot|  
  
## Visual Basic Constants  
 You can use constants defined in the [!INCLUDE[vbprvb](../../Topics/TopicNameContainA/includes/vbprvb_md.md)] run-time library in an expression. For example, you can use the constant **DateInterval.Day**. The following expression for the date January 10, 2008 returns the number 10:  
  
 `=DatePart("d",Globals!ExecutionTime)`  
  
## CLR Constants  
 You can use constants defined in [!INCLUDE[dnprdnshort](../../Topics/TopicNameContainA/includes/dnprdnshort_md.md)] common language run-time (CLR) classes in an expression. The following table shows an example of a system-defined color.  
  
|Constant|Description|  
|--------------|-----------------|  
|MistyRose|When you create an expression for a report property that is based on background color, you can specify a color by name. Valid names are listed in the **Expression** dialog box.|  
  
## See Also  
 [Expression Dialog Box](../../Topics/TopicNameNotContainA/Expression-Dialog-Box.md)   
 [Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expressions--Report-Builder-and-SSRS-.md)   
 [Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Examples--Report-Builder-and-SSRS-.md)   
 [Data Types in Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Types-in-Expressions--Report-Builder-and-SSRS-.md)   
 [Expression Dialog Box (Report Builder)](../../Topics/TopicNameNotContainA/Expression-Dialog-Box--Report-Builder-.md)