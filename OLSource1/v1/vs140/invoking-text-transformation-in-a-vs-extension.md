---
title: "Invoking Text Transformation in a VS Extension"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 64674976-841f-43cb-8e61-0645c8a89eec
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Invoking Text Transformation in a VS Extension
If you are writing a [Visual Studio extension](../Topic/Developing%20Visual%20Studio%20Extensions_deleted.md) such as a menu command or [domain-specific language](../vs140/modeling-sdk-for-visual-studio---domain-specific-languages.md), you can use the text templating service to transform text templates. Get the <xref:Microsoft.VisualStudio.TextTemplating.VSHost.STextTemplating?qualifyHint=False> service and cast it to <xref:Microsoft.VisualStudio.TextTemplating.VSHost.ITextTemplating?qualifyHint=False>.  
  
## Getting the text templating service  
  
```c#  
using Microsoft.VisualStudio.TextTemplating;  
using Microsoft.VisualStudio.TextTemplating.VSHost;  
...  
// Get a service provider – how you do this depends on the context:  
IServiceProvider serviceProvider = ...; // An instance of EnvDTE, for example   
  
// Get the text template service:  
ITextTemplating t4 = serviceProvider.GetService(typeof(STextTemplating)) as ITextTemplating;  
  
// Process a text template:  
string result = t4.ProcessTemplate(filePath, System.IO.File.ReadAllText(filePath));  
  
```  
  
## Passing parameters to the template  
 You can pass parameters into the template. Inside the template, you can get the parameter values by using the `<#@parameter#>` directive.  
  
 For the type of a parameter, you must use a type that is serializable or that can be marshaled. That is, the type must be declared with <xref:System.SerializableAttribute?qualifyHint=False>, or it must be derived from <xref:System.MarshalByRefObject?qualifyHint=False>. This restriction is necessary because the text template is executed in a separate AppDomain. All built-in types such as **System.String** and **System.Int32** are serializable.  
  
 To pass parameter values, the calling code can place values either in the `Session` dictionary, or in the <xref:System.Runtime.Remoting.Messaging.CallContext?qualifyHint=False>.  
  
 The following example uses both methods to transform a short test template:  
  
```  
using Microsoft.VisualStudio.TextTemplating;  
using Microsoft.VisualStudio.TextTemplating.VSHost;  
...  
// Get a service provider – how you do this depends on the context:  
IServiceProvider serviceProvider = dte;   
  
// Get the text template service:  
ITextTemplating t4 = serviceProvider.GetService(typeof(STextTemplating)) as ITextTemplating;  
ITextTemplatingSessionHost sessionHost = t4 as ITextTemplatingSessionHost;  
  
// Create a Session in which to pass parameters:  
sessionHost.Session = sessionHost.CreateSession();  
sessionHost.Session["parameter1"] = "Hello";  
sessionHost.Session["parameter2"] = DateTime.Now;  
  
// Pass another value in CallContext:  
System.Runtime.Remoting.Messaging.CallContext.LogicalSetData("parameter3", 42);  
  
// Process a text template:  
string result = t4.ProcessTemplate("",  
   // This is the test template:  
   "<#@parameter type=\"System.String\" name=\"parameter1\"#>"  
 + "<#@parameter type=\"System.DateTime\" name=\"parameter2\"#>"  
 + "<#@parameter type=\"System.Int32\" name=\"parameter3\"#>"  
 + "Test: <#=parameter1#>    <#=parameter2#>    <#=parameter3#>");  
  
// This test code yields a result similar to the following line:  
//     Test: Hello    07/06/2010 12:37:45    42  
  
```  
  
## Error Reporting and the Output Directive  
 Any errors that arise during processing will be displayed in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] error window. In addition, you can be notified of errors by specifying a callback that implements <xref:Microsoft.VisualStudio.TextTemplating.VSHost.ITextTemplatingCallback?qualifyHint=False>.  
  
 If you want to write the result string to a file, you might want to know what file extension and encoding have been specified in the `<#@output#>` directive in the template. This information will also be passed to your callback. For more information, see [Output Directive](../vs140/t4-output-directive.md).  
  
```c#  
void ProcessMyTemplate(string MyTemplateFile)  
{  
  string templateContent = File.ReadAllText(MyTemplateFile);  
  T4Callback cb = new T4Callback();  
  // Process a text template:  
  string result = t4.ProcessTemplate(MyTemplateFile, templateContent, cb);  
  // If there was an output directive in the MyTemplateFile,  
  // then cb.SetFileExtension() will have been called.  
  // Determine the output file name:  
  string resultFileName =   
    Path.Combine(Path.GetDirectoryName(MyTemplateFile),   
        Path.GetFileNameWithoutExtension(MyTemplateFile))   
      + cb.fileExtension;  
  // Write the processed output to file:  
  File.WriteAllText(resultFileName, result, cb.outputEncoding);  
  // Append any error messages:  
  if (cb.errorMessages.Count > 0)  
  {  
    File.AppendAllLines(resultFileName, cb.errorMessages);  
  }  
}  
  
class T4Callback : ITextTemplatingCallback  
{  
  public List<string> errorMessages = new List<string>();  
  public string fileExtension = ".txt";  
  public Encoding outputEncoding = Encoding.UTF8;  
  
  public void ErrorCallback(bool warning, string message, int line, int column)  
  { errorMessages.Add(message); }  
  
  public void SetFileExtension(string extension)  
  { fileExtension = extension; }  
  
  public void SetOutputEncoding(Encoding encoding, bool fromOutputDirective)  
  { outputEncoding = encoding; }  
}  
  
```  
  
 The code can be tested with a template file similar to the following:  
  
```  
<#@output extension=".htm" encoding="ASCII"#>  
<# int unused;  // Compiler warning "unused variable"  
#>  
Sample text.  
```  
  
 The compiler warning will appear in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] error window, and it will also generate a call to `ErrorCallback`.  
  
## Reference parameters  
 You can pass values out of a text template by using a parameter class that is derived from <xref:System.MarshalByRefObject?qualifyHint=False>.  
  
## Related Topics  
 To generate text from a preprocessed text template:  
 Call the `TransformText()` method of the generated class. For more information, see [Generating Text at Runtime by using Preprocessed Text Templates](../vs140/run-time-text-generation-with-t4-text-templates.md).  
  
 To generate text outside a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] extension:  
 Define a custom host. For more information, see [Processing Text Templates by Using a Custom Host](../vs140/processing-text-templates-by-using-a-custom-host.md).  
  
 To generate source code that can later be compiled and executed:  
 Call the `t4.PreprocessTemplate()` method of <xref:Microsoft.VisualStudio.TextTemplating.VSHost.ITextTemplating?qualifyHint=False>.