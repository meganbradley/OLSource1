---
title: "T4 Parameter Directive"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1d590387-1d9d-40a5-a72c-65fae7a8bdf3
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# T4 Parameter Directive
In a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] text template, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive declares properties in your template code that are initialized from values passed in from the external context. You can set these values if you write code that invokes text transformation.  
  
## Using the Parameter Directive  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive declares properties in your template code that are initialized from values passed in from the external context. You can set these values if you write code that invokes text transformation. The values can be passed either in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> dictionary, or in \<xref:System.Runtime.Remoting.Messaging.CallContext*>.  
  
 You can declare parameters of any remotable type. That is, the type must be declared with \<xref:System.SerializableAttribute*>, or it must derive from \<xref:System.MarshalByRefObject*>. This allows parameter values to be passed into the AppDomain in which the template is processed.  
  
 For example, you could write a text template with the following content:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Passing parameter values to a template  
 If you are writing a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extension such as a menu command or an event handler, you can process a template by using the text templating service:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Passing values in the Call Context  
 You can alternatively pass values as logical data in \<xref:System.Runtime.Remoting.Messaging.CallContext*>.  
  
 The following example passes values by using both methods:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Passing values to a Run-Time (Preprocessed) Text Template  
 It is not usually necessary to use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive with run-time (preprocessed) text templates. Instead, you can define an additional constructor or a settable property for the generated code, through which you pass parameter values. For more information, see [Generating Text Files at Run Time by Using Preprocessed Text Templates](../vs140/run-time-text-generation-with-t4-text-templates.md).  
  
 However, if you want to use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in a run-time template, you can pass values to it by using the Session dictionary. As an example, suppose you have created the file as a preprocessed template called <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. You can invoke the template in your program by using the following code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Obtaining arguments from TextTemplate.exe  
  
> [!IMPORTANT]
>  The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directive does not retrieve values set in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> utility. To get those values, set <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> directive, and use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.