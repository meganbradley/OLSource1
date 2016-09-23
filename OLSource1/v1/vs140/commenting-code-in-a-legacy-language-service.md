---
title: "Commenting Code in a Legacy Language Service"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - comments, supporting in language services [managed package framework]
  - language services [managed package framework], commenting code
ms.assetid: 9600d6f0-e2b6-4fe0-b935-fb32affb97a4
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Commenting Code in a Legacy Language Service
Programming languages typically provide a means to annotate or comment the code. A comment is a section of text that provides additional information about the code but is ignored during compilation or interpretation.  
  
 The managed package framework (MPF) classes provide support for commenting and uncommenting selected text.  
  
## Comment Styles  
 There are two general styles of comment:  
  
1.  Line comments, where the comment is on a single line.  
  
2.  Block comments, where the comment may include multiple lines.  
  
 Line comments typically have a starting character (or characters), while block comments have both start and end characters. For example, in C#, a line comment starts with //, and a block comment starts with /* and ends with \*/.  
  
 When the user selects the command **Comment Selection** from the **Edit** -> **Advanced** menu, the command is routed to the <xref:Microsoft.VisualStudio.Package.Source.CommentSpan?qualifyHint=False> method on the <xref:Microsoft.VisualStudio.Package.Source?qualifyHint=False> class. When the user selects the command **Uncomment Selection**, the command is routed to the <xref:Microsoft.VisualStudio.Package.Source.UncommentSpan?qualifyHint=False> method.  
  
## Supporting Code Comments  
 You can have your language service support code comments by means of the `EnableCommenting` named parameter of the <xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute?qualifyHint=False> . This sets the <xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableCommenting?qualifyHint=False> property of the <xref:Microsoft.VisualStudio.Package.LanguagePreferences?qualifyHint=False> class. For more information about setting language servicce features, see [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md)).  
  
 You must also override the <xref:Microsoft.VisualStudio.Package.Source.GetCommentFormat?qualifyHint=False> method to return a <xref:Microsoft.VisualStudio.Package.CommentInfo?qualifyHint=False> structure with the comment characters for your language. C#-style line comment characters are the default.  
  
### Example  
 Here is an example implementation of the <xref:Microsoft.VisualStudio.Package.Source.GetCommentFormat?qualifyHint=False> method.  
  
```c#  
using Microsoft.VisualStudio.Package;  
  
namespace MyLanguagePackage  
{  
    class MySource : Source  
    {  
        public override CommentInfo GetCommentFormat() {  
            CommentInfo info = new CommentInfo();  
            info.LineStart       = "//";  
            info.BlockStart      = "/*";  
            info.BlockEnd        = "*/";  
            info.UseLineComments = true;  
            return info;  
        }  
    }  
}  
```  
  
## See Also  
 [Language Service Features (Managed Package Framework)](../vs140/legacy-language-service-features1.md)   
 [Registering a Language Service (Managed Package Framework)](../vs140/registering-a-legacy-language-service1.md)