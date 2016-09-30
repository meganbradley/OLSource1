---
title: "Invoking Text Transformation in a VS Extension"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 64674976-841f-43cb-8e61-0645c8a89eec
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Invoking Text Transformation in a VS Extension
If you are writing a [Visual Studio extension](../Topic/Developing%20Visual%20Studio%20Extensions_deleted.md) such as a menu command or [domain-specific language](../vs140/modeling-sdk-for-visual-studio---domain-specific-languages.md), you can use the text templating service to transform text templates. Get the \<xref:Microsoft.VisualStudio.TextTemplating.VSHost.STextTemplating*> service and cast it to \<xref:Microsoft.VisualStudio.TextTemplating.VSHost.ITextTemplating*>.  
  
## Getting the text templating service  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Passing parameters to the template  
 You can pass parameters into the template. Inside the template, you can get the parameter values by using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive.  
  
 For the type of a parameter, you must use a type that is serializable or that can be marshaled. That is, the type must be declared with \<xref:System.SerializableAttribute*>, or it must be derived from \<xref:System.MarshalByRefObject*>. This restriction is necessary because the text template is executed in a separate AppDomain. All built-in types such as **System.String** and **System.Int32** are serializable.  
  
 To pass parameter values, the calling code can place values either in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> dictionary, or in the \<xref:System.Runtime.Remoting.Messaging.CallContext*>.  
  
 The following example uses both methods to transform a short test template:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Error Reporting and the Output Directive  
 Any errors that arise during processing will be displayed in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] error window. In addition, you can be notified of errors by specifying a callback that implements \<xref:Microsoft.VisualStudio.TextTemplating.VSHost.ITextTemplatingCallback*>.  
  
 If you want to write the result string to a file, you might want to know what file extension and encoding have been specified in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive in the template. This information will also be passed to your callback. For more information, see [Output Directive](../vs140/t4-output-directive.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The code can be tested with a template file similar to the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The compiler warning will appear in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] error window, and it will also generate a call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Reference parameters  
 You can pass values out of a text template by using a parameter class that is derived from \<xref:System.MarshalByRefObject*>.  
  
## Related Topics  
 To generate text from a preprocessed text template:  
 Call the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method of the generated class. For more information, see [Generating Text at Runtime by using Preprocessed Text Templates](../vs140/run-time-text-generation-with-t4-text-templates.md).  
  
 To generate text outside a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extension:  
 Define a custom host. For more information, see [Processing Text Templates by Using a Custom Host](../vs140/processing-text-templates-by-using-a-custom-host.md).  
  
 To generate source code that can later be compiled and executed:  
 Call the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method of \<xref:Microsoft.VisualStudio.TextTemplating.VSHost.ITextTemplating*>.