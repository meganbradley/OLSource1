---
title: "Word Completion in a Legacy Language Service"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "language services [managed package framework], IntelliSense Complete Word"
  - "IntelliSense, Complete Word"
  - "Complete Word"
ms.assetid: 0ace5ac3-f9e1-4e6d-add4-42967b1f96a6
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Word Completion in a Legacy Language Service
Word completion fills in the missing characters on a partially typed word. If there is only one possible completion, the word is completed when the completion character is entered. If the partial word matches more than one possibility, a list of possible completions is displayed. A completion character can be any character that is not used for identifiers.  
  
 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more, see [Extending the Editor](../vs140/extending-the-editor-and-language-services.md).  
  
> [!NOTE]
>  We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.  
  
## Implementation Steps  
  
1.  When the user selects **Complete Word** from the **IntelliSense** menu, the \<xref:Microsoft.VisualStudio.VSConstants.VSStd2KCmdID.COMPLETEWORD*> command is sent to the language service.  
  
2.  The \<xref:Microsoft.VisualStudio.Package.ViewFilter*> class catches the command and calls the \<xref:Microsoft.VisualStudio.Package.Source.Completion*> method with the parse reason of \<xref:Microsoft.VisualStudio.Package.ParseReason.CompleteWord*>.  
  
3.  The \<xref:Microsoft.VisualStudio.Package.Source*> class then calls the \<xref:Microsoft.VisualStudio.Package.LanguageService.ParseSource*> method to get the list of possible word completions and then displays the words in a tool tip list using the \<xref:Microsoft.VisualStudio.Package.CompletionSet*> class.  
  
     If there is only one matching word, the \<xref:Microsoft.VisualStudio.Package.Source*> class completes the word.  
  
 Alternatively, if the scanner returns the trigger value \<xref:Microsoft.VisualStudio.Package.TokenTriggers.MemberSelect*> when the first character of an identifier is typed, the \<xref:Microsoft.VisualStudio.Package.Source*> class detects this and calls the \<xref:Microsoft.VisualStudio.Package.Source.Completion*> method with the parse reason of \<xref:Microsoft.VisualStudio.Package.ParseReason.MemberSelect*>. In this case the parser must detect the presence of a member selection character and provide a list of members.  
  
## Enabling Support for the Complete Word  
 To enable support for word completion set the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> named parameter passed to the \<xref:Microsoft.VisualStudio.Shell.ProvideLanguageServiceAttribute*> user attribute associated with the language package. This sets the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences.EnableCodeSense*> property on the \<xref:Microsoft.VisualStudio.Package.LanguagePreferences*> class.  
  
 Your parser must return a list of declarations in response to the parse reason value \<xref:Microsoft.VisualStudio.Package.ParseReason.CompleteWord*>, for word completion to operate.  
  
## Implementing Complete Word in the ParseSource Method  
 For word completion, the \<xref:Microsoft.VisualStudio.Package.Source*> class calls the \<xref:Microsoft.VisualStudio.Package.AuthoringScope.GetDeclarations*> method on the \<xref:Microsoft.VisualStudio.Package.AuthoringScope*> class to obtain a list of possible word matches. You must implement the list in a class that is derived from the \<xref:Microsoft.VisualStudio.Package.Declarations*> class. See the \<xref:Microsoft.VisualStudio.Package.Declarations*> class for details on the methods you must implement.  
  
 If the list contains only a single word, then the \<xref:Microsoft.VisualStudio.Package.Source*> class automatically inserts that word in place of the partial word. If the list contains more than one word, the \<xref:Microsoft.VisualStudio.Package.Source*> class presents a tool tip list from which the user can select the appropriate choice.  
  
 Also look at the example of a \<xref:Microsoft.VisualStudio.Package.Declarations*> class implementation in [Supporting IntelliSense Member Completion (Managed Package Framework)](../vs140/member-completion-in-a-legacy-language-service.md).