---
title: "C Identifiers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "identifiers, C"
  - "naming identifiers"
  - "identifiers"
  - "symbols, C identifiers"
  - "identifiers, case sensitivity"
  - "symbols, case sensitivity"
ms.assetid: d02edbbc-85a0-4118-997b-84ee6b972eb6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Identifiers
"Identifiers" or "symbols" are the names you supply for variables, types, functions, and labels in your program. Identifier names must differ in spelling and case from any keywords. You cannot use keywords (either C or Microsoft) as identifiers; they are reserved for special use. You create an identifier by specifying it in the declaration of a variable, type, or function. In this example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an identifier for an integer variable, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are identifier names for functions.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Once declared, you can use the identifier in later program statements to refer to the associated value.  
  
 A special kind of identifier, called a statement label, can be used in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statements. (Declarations are described in [Declarations and Types](../vs140/declarations-and-types.md) Statement labels are described in [The goto and Labeled Statements](../vs140/goto-and-labeled-statements--c-.md).)  
  
## Syntax  
 *identifier*:  
 *nondigit*  
  
 *identifier nondigit*  
  
 *identifier digit*  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>: one of  
 **_ a b c d e f g h i j k l m n o p q r s t u v w x y z**  
  
 **A B C D E F G H I J K L M N O P Q R S T U V W X Y Z**  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>: one of  
 **0 1 2 3 4 5 6 7 8 9**  
  
 The first character of an identifier name must be a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (that is, the first character must be an underscore or an uppercase or lowercase letter). ANSI allows six significant characters in an external identifier's name and 31 for names of internal (within a function) identifiers. External identifiers (ones declared at global scope or declared with storage class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) may be subject to additional naming restrictions because these identifiers have to be processed by other software such as linkers.  
  
 **Microsoft Specific**  
  
 Although ANSI allows 6 significant characters in external identifier names and 31 for names of internal (within a function) identifiers, the Microsoft C compiler allows 247 characters in an internal or external identifier name. If you aren't concerned with ANSI compatibility, you can modify this default to a smaller or larger number using the /H (restrict length of external names) option.  
  
 **END Microsoft Specific**  
  
 The C compiler considers uppercase and lowercase letters to be distinct characters. This feature, called "case sensitivity," enables you to create distinct identifiers that have the same spelling but different cases for one or more of the letters. For example, each of the following identifiers is unique:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Microsoft Specific**  
  
 Do not select names for identifiers that begin with two underscores or with an underscore followed by an uppercase letter. The ANSI C standard allows identifier names that begin with these character combinations to be reserved for compiler use. Identifiers with file-level scope should also not be named with an underscore and a lowercase letter as the first two letters. Identifier names that begin with these characters are also reserved. By convention, Microsoft uses an underscore and an uppercase letter to begin macro names and double underscores for Microsoft-specific keyword names. To avoid any naming conflicts, always select identifier names that do not begin with one or two underscores, or names that begin with an underscore followed by an uppercase letter.  
  
 **END Microsoft Specific**  
  
 The following are examples of valid identifiers that conform to either ANSI or Microsoft naming restrictions:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Microsoft Specific**  
  
 Although identifiers in source files are case sensitive by default, symbols in object files are not. Microsoft C treats identifiers within a compilation unit as case sensitive.  
  
 The Microsoft linker is case sensitive. You must specify all identifiers consistently according to case.  
  
 The "source character set" is the set of legal characters that can appear in source files. For Microsoft C, the source set is the standard ASCII character set. The source character set and execution character set include the ASCII characters used as escape sequences. See [Character Constants](../vs140/c-character-constants.md) for information about the execution character set.  
  
 **END Microsoft Specific**  
  
 An identifier has "scope," which is the region of the program in which it is known, and "linkage," which determines whether the same name in another scope refers to the same identifier. These topics are explained in [Lifetime, Scope, Visibility, and Linkage](../vs140/lifetime--scope--visibility--and-linkage.md).  
  
## See Also  
 [Elements of C](../vs140/elements-of-c.md)