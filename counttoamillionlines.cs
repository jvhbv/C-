/*
counttoamillionlines is a program that does exactly what it says, it counts to 1,000,000 printing 7 numbers per line in the console
Copyright (C) 2017 Joseph Van Horn

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

In order to contact me, email me at texasalamocode@gmail.com
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace onemillion
{
    class Program
    {
        class Person
        {
            int repeat = 0;
            public void SayHi()
            {
                Console.WriteLine("random stuff in C# Copyright (c) 2017 Joseph Van Horn");
                Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type `show w'.");
                Console.WriteLine("This is free software, and you are welcome to redistribute it");
                Console.WriteLine("under certain conditions; type `show c' for details.");
                string input = Console.ReadLine();
                if(input == "show c")   // The actual code begins at line 585 if you don't want to read the entire GPL
                {
                    Console.WriteLine("                       TERMS AND CONDITIONS");
                    Console.WriteLine("");
                    Console.WriteLine("0. Definitions.");
                    Console.WriteLine("");
                    Console.WriteLine("'This License' refers to version 3 of the GNU General Public License.");
                    Console.WriteLine("");
                    Console.WriteLine("'Copyright' also means copyright-like laws that apply to other kinds of");
                    Console.WriteLine("works, such as semiconductor masks.");
                    Console.WriteLine("");
                    Console.WriteLine("'The Program' refers to any copyrightable work licensed under this");
                    Console.WriteLine("License.  Each licensee is addressed as 'you'.  'Licensees' and");
                    Console.WriteLine("'recipients' may be individuals or organizations.");
                    Console.WriteLine("");
                    Console.WriteLine("To 'modify' a work means to copy from or adapt all or part of the work");
                    Console.WriteLine("in a fashion requiring copyright permission, other than the making of an");
                    Console.WriteLine("exact copy.  The resulting work is called a 'modified version' of the");
                    Console.WriteLine("earlier work or a work 'based on' the earlier work.");
                    Console.WriteLine("");
                    Console.WriteLine("A 'covered work' means either the unmodified Program or a work based");
                    Console.WriteLine("on the Program.");
                    Console.WriteLine("");
                    Console.WriteLine("To 'propagate' a work means to do anything with it that, without");
                    Console.WriteLine("permission, would make you directly or secondarily liable for");
                    Console.WriteLine("infringement under applicable copyright law, except executing it on a");
                    Console.WriteLine("computer or modifying a private copy.  Propagation includes copying,");
                    Console.WriteLine("distribution (with or without modification), making available to the");
                    Console.WriteLine("public, and in some countries other activities as well.");
                    Console.WriteLine("");
                    Console.WriteLine("To 'convey' a work means any kind of propagation that enables other");
                    Console.WriteLine("parties to make or receive copies.  Mere interaction with a user through");
                    Console.WriteLine("a computer network, with no transfer of a copy, is not conveying.");
                    Console.WriteLine("");
                    Console.WriteLine("An interactive user interface displays 'Appropriate Legal Notices'");
                    Console.WriteLine("to the extent that it includes a convenient and prominently visible");
                    Console.WriteLine("feature that (1) displays an appropriate copyright notice, and (2)");
                    Console.WriteLine("tells the user that there is no warranty for the work (except to the");
                    Console.WriteLine("extent that warranties are provided), that licensees may convey the");
                    Console.WriteLine("work under this License, and how to view a copy of this License.  If");
                    Console.WriteLine("the interface presents a list of user commands or options, such as a");
                    Console.WriteLine("menu, a prominent item in the list meets this criterion.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("1. Source Code.");
                    Console.WriteLine("");
                    Console.WriteLine("The 'source code' for a work means the preferred form of the work");
                    Console.WriteLine("for making modifications to it.  'Object code' means any non-source");
                    Console.WriteLine("form of a work.");
                    Console.WriteLine("");
                    Console.WriteLine("A 'Standard Interface' means an interface that either is an official");
                    Console.WriteLine("standard defined by a recognized standards body, or, in the case of");
                    Console.WriteLine("interfaces specified for a particular programming language, one that");
                    Console.WriteLine("is widely used among developers working in that language.");
                    Console.WriteLine("");
                    Console.WriteLine("The 'System Libraries' of an executable work include anything, other");
                    Console.WriteLine("than the work as a whole, that (a) is included in the normal form of");
                    Console.WriteLine("packaging a Major Component, but which is not part of that Major");
                    Console.WriteLine("Component, and (b) serves only to enable use of the work with that");
                    Console.WriteLine("Major Component, or to implement a Standard Interface for which an");
                    Console.WriteLine("implementation is available to the public in source code form.  A");
                    Console.WriteLine("'Major Component', in this context, means a major essential component");
                    Console.WriteLine("(kernel, window system, and so on) of the specific operating system");
                    Console.WriteLine("(if any) on which the executable work runs, or a compiler used to");
                    Console.WriteLine("produce the work, or an object code interpreter used to run it.");
                    Console.WriteLine("");
                    Console.WriteLine("The 'Corresponding Source' for a work in object code form means all");
                    Console.WriteLine("the source code needed to generate, install, and (for an executable");
                    Console.WriteLine("work) run the object code and to modify the work, including scripts to");
                    Console.WriteLine("control those activities.  However, it does not include the work's");
                    Console.WriteLine("System Libraries, or general-purpose tools or generally available free");
                    Console.WriteLine("programs which are used unmodified in performing those activities but");
                    Console.WriteLine("which are not part of the work.  For example, Corresponding Source");
                    Console.WriteLine("includes interface definition files associated with source files for");
                    Console.WriteLine("the work, and the source code for shared libraries and dynamically");
                    Console.WriteLine("linked subprograms that the work is specifically designed to require,");
                    Console.WriteLine("such as by intimate data communication or control flow between those");
                    Console.WriteLine("subprograms and other parts of the work.");
                    Console.WriteLine("");
                    Console.WriteLine("The Corresponding Source need not include anything that users");
                    Console.WriteLine("can regenerate automatically from other parts of the Corresponding");
                    Console.WriteLine("Source.");
                    Console.WriteLine("");
                    Console.WriteLine("The Corresponding Source for a work in source code form is that");
                    Console.WriteLine("same work.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("2. Basic Permissions.");
                    Console.WriteLine("");
                    Console.WriteLine("All rights granted under this License are granted for the term of");
                    Console.WriteLine("copyright on the Program, and are irrevocable provided the stated");
                    Console.WriteLine("conditions are met.  This License explicitly affirms your unlimited");
                    Console.WriteLine("permission to run the unmodified Program.  The output from running a");
                    Console.WriteLine("covered work is covered by this License only if the output, given its");
                    Console.WriteLine("content, constitutes a covered work.  This License acknowledges your");
                    Console.WriteLine("rights of fair use or other equivalent, as provided by copyright law.");
                    Console.WriteLine("");
                    Console.WriteLine("You may make, run and propagate covered works that you do not");
                    Console.WriteLine("convey, without conditions so long as your license otherwise remains");
                    Console.WriteLine("in force.  You may convey covered works to others for the sole purpose");
                    Console.WriteLine("of having them make modifications exclusively for you, or provide you");
                    Console.WriteLine("with facilities for running those works, provided that you comply with");
                    Console.WriteLine("the terms of this License in conveying all material for which you do");
                    Console.WriteLine("not control copyright.  Those thus making or running the covered works");
                    Console.WriteLine("for you must do so exclusively on your behalf, under your direction");
                    Console.WriteLine("and control, on terms that prohibit them from making any copies of");
                    Console.WriteLine("your copyrighted material outside their relationship with you.");
                    Console.WriteLine("");
                    Console.WriteLine("Conveying under any other circumstances is permitted solely under");
                    Console.WriteLine("the conditions stated below.  Sublicensing is not allowed; section 10");
                    Console.WriteLine("makes it unnecessary.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("3. Protecting Users' Legal Rights From Anti-Circumvention Law.");
                    Console.WriteLine("");
                    Console.WriteLine("No covered work shall be deemed part of an effective technological");
                    Console.WriteLine("measure under any applicable law fulfilling obligations under article");
                    Console.WriteLine("11 of the WIPO copyright treaty adopted on 20 December 1996, or");
                    Console.WriteLine("similar laws prohibiting or restricting circumvention of such");
                    Console.WriteLine("measures.");
                    Console.WriteLine("");
                    Console.WriteLine("When you convey a covered work, you waive any legal power to forbid");
                    Console.WriteLine("circumvention of technological measures to the extent such circumvention");
                    Console.WriteLine("is effected by exercising rights under this License with respect to");
                    Console.WriteLine("the covered work, and you disclaim any intention to limit operation or");
                    Console.WriteLine("modification of the work as a means of enforcing, against the work's");
                    Console.WriteLine("users, your or third parties' legal rights to forbid circumvention of");
                    Console.WriteLine("technological measures.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("4. Conveying Verbatim Copies.");
                    Console.WriteLine("");
                    Console.WriteLine("You may convey verbatim copies of the Program's source code as you");
                    Console.WriteLine("receive it, in any medium, provided that you conspicuously and");
                    Console.WriteLine("appropriately publish on each copy an appropriate copyright notice;");
                    Console.WriteLine("keep intact all notices stating that this License and any");
                    Console.WriteLine("non-permissive terms added in accord with section 7 apply to the code;");
                    Console.WriteLine("keep intact all notices of the absence of any warranty; and give all");
                    Console.WriteLine("recipients a copy of this License along with the Program.");
                    Console.WriteLine("");
                    Console.WriteLine("You may charge any price or no price for each copy that you convey,");
                    Console.WriteLine("and you may offer support or warranty protection for a fee.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("5. Conveying Modified Source Versions.");
                    Console.WriteLine("");
                    Console.WriteLine("You may convey a work based on the Program, or the modifications to");
                    Console.WriteLine("produce it from the Program, in the form of source code under the");
                    Console.WriteLine("terms of section 4, provided that you also meet all of these conditions:");
                    Console.WriteLine("");
                    Console.WriteLine("a) The work must carry prominent notices stating that you modified");
                    Console.WriteLine("it, and giving a relevant date.");
                    Console.WriteLine("");
                    Console.WriteLine("b) The work must carry prominent notices stating that it is");
                    Console.WriteLine("released under this License and any conditions added under section");
                    Console.WriteLine("7.  This requirement modifies the requirement in section 4 to");
                    Console.WriteLine("'keep intact all notices'.");
                    Console.WriteLine("");
                    Console.WriteLine("c) You must license the entire work, as a whole, under this");
                    Console.WriteLine("License to anyone who comes into possession of a copy.  This");
                    Console.WriteLine("License will therefore apply, along with any applicable section 7");
                    Console.WriteLine("additional terms, to the whole of the work, and all its parts,");
                    Console.WriteLine("regardless of how they are packaged.  This License gives no");
                    Console.WriteLine("permission to license the work in any other way, but it does not");
                    Console.WriteLine("invalidate such permission if you have separately received it.");
                    Console.WriteLine("");
                    Console.WriteLine("d) If the work has interactive user interfaces, each must display");
                    Console.WriteLine("Appropriate Legal Notices; however, if the Program has interactive");
                    Console.WriteLine("interfaces that do not display Appropriate Legal Notices, your");
                    Console.WriteLine("work need not make them do so.");
                    Console.WriteLine("");
                    Console.WriteLine("A compilation of a covered work with other separate and independent");
                    Console.WriteLine("works, which are not by their nature extensions of the covered work,");
                    Console.WriteLine("and which are not combined with it such as to form a larger program,");
                    Console.WriteLine("in or on a volume of a storage or distribution medium, is called an");
                    Console.WriteLine("'aggregate' if the compilation and its resulting copyright are not");
                    Console.WriteLine("used to limit the access or legal rights of the compilation's users");
                    Console.WriteLine("beyond what the individual works permit.  Inclusion of a covered work");
                    Console.WriteLine("in an aggregate does not cause this License to apply to the other");
                    Console.WriteLine("parts of the aggregate.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("6. Conveying Non-Source Forms.");
                    Console.WriteLine("");
                    Console.WriteLine("You may convey a covered work in object code form under the terms");
                    Console.WriteLine("of sections 4 and 5, provided that you also convey the");
                    Console.WriteLine("machine-readable Corresponding Source under the terms of this License,");
                    Console.WriteLine("in one of these ways:");
                    Console.WriteLine("");
                    Console.WriteLine("a) Convey the object code in, or embodied in, a physical product");
                    Console.WriteLine("(including a physical distribution medium), accompanied by the");
                    Console.WriteLine("Corresponding Source fixed on a durable physical medium");
                    Console.WriteLine("customarily used for software interchange.");
                    Console.WriteLine("");
                    Console.WriteLine("b) Convey the object code in, or embodied in, a physical product");
                    Console.WriteLine("(including a physical distribution medium), accompanied by a");
                    Console.WriteLine("written offer, valid for at least three years and valid for as");
                    Console.WriteLine("long as you offer spare parts or customer support for that product");
                    Console.WriteLine("model, to give anyone who possesses the object code either (1) a");
                    Console.WriteLine("copy of the Corresponding Source for all the software in the");
                    Console.WriteLine("product that is covered by this License, on a durable physical");
                    Console.WriteLine("medium customarily used for software interchange, for a price no");
                    Console.WriteLine("more than your reasonable cost of physically performing this");
                    Console.WriteLine("conveying of source, or (2) access to copy the");
                    Console.WriteLine("Corresponding Source from a network server at no charge.");
                    Console.WriteLine("");
                    Console.WriteLine("c) Convey individual copies of the object code with a copy of the");
                    Console.WriteLine("written offer to provide the Corresponding Source.  This");
                    Console.WriteLine("alternative is allowed only occasionally and noncommercially, and");
                    Console.WriteLine("only if you received the object code with such an offer, in accord");
                    Console.WriteLine("with subsection 6b.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("d) Convey the object code by offering access from a designated");
                    Console.WriteLine("place (gratis or for a charge), and offer equivalent access to the");
                    Console.WriteLine("Corresponding Source in the same way through the same place at no");
                    Console.WriteLine("further charge.  You need not require recipients to copy the");
                    Console.WriteLine("Corresponding Source along with the object code.  If the place to");
                    Console.WriteLine("copy the object code is a network server, the Corresponding Source");
                    Console.WriteLine("may be on a different server (operated by you or a third party)");
                    Console.WriteLine("that supports equivalent copying facilities, provided you maintain");
                    Console.WriteLine("clear directions next to the object code saying where to find the");
                    Console.WriteLine("Corresponding Source.  Regardless of what server hosts the");
                    Console.WriteLine("Corresponding Source, you remain obligated to ensure that it is");
                    Console.WriteLine("available for as long as needed to satisfy these requirements.");
                    Console.WriteLine("");
                    Console.WriteLine("e) Convey the object code using peer-to-peer transmission, provided");
                    Console.WriteLine("you inform other peers where the object code and Corresponding");
                    Console.WriteLine("Source of the work are being offered to the general public at no");
                    Console.WriteLine("charge under subsection 6d.");
                    Console.WriteLine("");
                    Console.WriteLine("A separable portion of the object code, whose source code is excluded");
                    Console.WriteLine("from the Corresponding Source as a System Library, need not be");
                    Console.WriteLine("included in conveying the object code work.");
                    Console.WriteLine("");
                    Console.WriteLine("A 'User Product' is either (1) a 'consumer product', which means any");
                    Console.WriteLine("tangible personal property which is normally used for personal, family,");
                    Console.WriteLine("or household purposes, or (2) anything designed or sold for incorporation");
                    Console.WriteLine("into a dwelling.  In determining whether a product is a consumer product,");
                    Console.WriteLine("doubtful cases shall be resolved in favor of coverage.  For a particular");
                    Console.WriteLine("product received by a particular user, 'normally used' refers to a");
                    Console.WriteLine("typical or common use of that class of product, regardless of the status");
                    Console.WriteLine("of the particular user or of the way in which the particular user");
                    Console.WriteLine("actually uses, or expects or is expected to use, the product.  A product");
                    Console.WriteLine("is a consumer product regardless of whether the product has substantial");
                    Console.WriteLine("commercial, industrial or non-consumer uses, unless such uses represent");
                    Console.WriteLine("the only significant mode of use of the product.");
                    Console.WriteLine("");
                    Console.WriteLine("'Installation Information' for a User Product means any methods,");
                    Console.WriteLine("procedures, authorization keys, or other information required to install");
                    Console.WriteLine("and execute modified versions of a covered work in that User Product from");
                    Console.WriteLine("a modified version of its Corresponding Source.  The information must");
                    Console.WriteLine("suffice to ensure that the continued functioning of the modified object");
                    Console.WriteLine("code is in no case prevented or interfered with solely because");
                    Console.WriteLine("modification has been made.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("If you convey an object code work under this section in, or with, or");
                    Console.WriteLine("specifically for use in, a User Product, and the conveying occurs as");
                    Console.WriteLine("part of a transaction in which the right of possession and use of the");
                    Console.WriteLine("User Product is transferred to the recipient in perpetuity or for a");
                    Console.WriteLine("fixed term (regardless of how the transaction is characterized), the");
                    Console.WriteLine("Corresponding Source conveyed under this section must be accompanied");
                    Console.WriteLine("by the Installation Information.  But this requirement does not apply");
                    Console.WriteLine("if neither you nor any third party retains the ability to install");
                    Console.WriteLine("modified object code on the User Product (for example, the work has");
                    Console.WriteLine("been installed in ROM).");
                    Console.WriteLine("");
                    Console.WriteLine("The requirement to provide Installation Information does not include a");
                    Console.WriteLine("requirement to continue to provide support service, warranty, or updates");
                    Console.WriteLine("for a work that has been modified or installed by the recipient, or for");
                    Console.WriteLine("the User Product in which it has been modified or installed.  Access to a");
                    Console.WriteLine("network may be denied when the modification itself materially and");
                    Console.WriteLine("adversely affects the operation of the network or violates the rules and");
                    Console.WriteLine("protocols for communication across the network.");
                    Console.WriteLine("");
                    Console.WriteLine("Corresponding Source conveyed, and Installation Information provided,");
                    Console.WriteLine("in accord with this section must be in a format that is publicly");
                    Console.WriteLine("documented (and with an implementation available to the public in");
                    Console.WriteLine("source code form), and must require no special password or key for");
                    Console.WriteLine("unpacking, reading or copying.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("7. Additional Terms.");
                    Console.WriteLine("");
                    Console.WriteLine("'Additional permissions' are terms that supplement the terms of this");
                    Console.WriteLine("License by making exceptions from one or more of its conditions.");
                    Console.WriteLine("Additional permissions that are applicable to the entire Program shall");
                    Console.WriteLine("be treated as though they were included in this License, to the extent");
                    Console.WriteLine("that they are valid under applicable law.  If additional permissions");
                    Console.WriteLine("apply only to part of the Program, that part may be used separately");
                    Console.WriteLine("under those permissions, but the entire Program remains governed by");
                    Console.WriteLine("this License without regard to the additional permissions.");
                    Console.WriteLine("");
                    Console.WriteLine("When you convey a copy of a covered work, you may at your option");
                    Console.WriteLine("remove any additional permissions from that copy, or from any part of");
                    Console.WriteLine("it.  (Additional permissions may be written to require their own");
                    Console.WriteLine("removal in certain cases when you modify the work.)  You may place");
                    Console.WriteLine("additional permissions on material, added by you to a covered work,");
                    Console.WriteLine("for which you have or can give appropriate copyright permission.");
                    Console.WriteLine("");
                    Console.WriteLine("Notwithstanding any other provision of this License, for material you");
                    Console.WriteLine("add to a covered work, you may (if authorized by the copyright holders of");
                    Console.WriteLine("that material) supplement the terms of this License with terms:");
                    Console.WriteLine("");
                    Console.WriteLine("a) Disclaiming warranty or limiting liability differently from the");
                    Console.WriteLine("terms of sections 15 and 16 of this License; or");
                    Console.WriteLine("");
                    Console.WriteLine("b) Requiring preservation of specified reasonable legal notices or");
                    Console.WriteLine("author attributions in that material or in the Appropriate Legal");
                    Console.WriteLine("Notices displayed by works containing it; or");
                    Console.WriteLine("");
                    Console.WriteLine("c) Prohibiting misrepresentation of the origin of that material, or");
                    Console.WriteLine("requiring that modified versions of such material be marked in");
                    Console.WriteLine("reasonable ways as different from the original version; or");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("d) Limiting the use for publicity purposes of names of licensors or");
                    Console.WriteLine("authors of the material; or");
                    Console.WriteLine("");
                    Console.WriteLine("e) Declining to grant rights under trademark law for use of some");
                    Console.WriteLine("trade names, trademarks, or service marks; or");
                    Console.WriteLine("");
                    Console.WriteLine("f) Requiring indemnification of licensors and authors of that");
                    Console.WriteLine("material by anyone who conveys the material (or modified versions of");
                    Console.WriteLine("it) with contractual assumptions of liability to the recipient, for");
                    Console.WriteLine("any liability that these contractual assumptions directly impose on");
                    Console.WriteLine("those licensors and authors.");
                    Console.WriteLine("");
                    Console.WriteLine("All other non-permissive additional terms are considered 'further");
                    Console.WriteLine("restrictions' within the meaning of section 10.  If the Program as you");
                    Console.WriteLine("received it, or any part of it, contains a notice stating that it is");
                    Console.WriteLine("governed by this License along with a term that is a further");
                    Console.WriteLine("restriction, you may remove that term.  If a license document contains");
                    Console.WriteLine("a further restriction but permits relicensing or conveying under this");
                    Console.WriteLine("License, you may add to a covered work material governed by the terms");
                    Console.WriteLine("of that license document, provided that the further restriction does");
                    Console.WriteLine("not survive such relicensing or conveying.");
                    Console.WriteLine("");
                    Console.WriteLine("If you add terms to a covered work in accord with this section, you");
                    Console.WriteLine("must place, in the relevant source files, a statement of the");
                    Console.WriteLine("additional terms that apply to those files, or a notice indicating");
                    Console.WriteLine("where to find the applicable terms.");
                    Console.WriteLine("");
                    Console.WriteLine("Additional terms, permissive or non-permissive, may be stated in the");
                    Console.WriteLine("form of a separately written license, or stated as exceptions;");
                    Console.WriteLine("the above requirements apply either way.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("8. Termination.");
                    Console.WriteLine("");
                    Console.WriteLine("You may not propagate or modify a covered work except as expressly");
                    Console.WriteLine("provided under this License.  Any attempt otherwise to propagate or");
                    Console.WriteLine("modify it is void, and will automatically terminate your rights under");
                    Console.WriteLine("this License (including any patent licenses granted under the third");
                    Console.WriteLine("paragraph of section 11).");
                    Console.WriteLine("");
                    Console.WriteLine("However, if you cease all violation of this License, then your");
                    Console.WriteLine("license from a particular copyright holder is reinstated (a)");
                    Console.WriteLine("provisionally, unless and until the copyright holder explicitly and");
                    Console.WriteLine("finally terminates your license, and (b) permanently, if the copyright");
                    Console.WriteLine("holder fails to notify you of the violation by some reasonable means");
                    Console.WriteLine("prior to 60 days after the cessation.");
                    Console.WriteLine("");
                    Console.WriteLine("Moreover, your license from a particular copyright holder is");
                    Console.WriteLine("reinstated permanently if the copyright holder notifies you of the");
                    Console.WriteLine("violation by some reasonable means, this is the first time you have");
                    Console.WriteLine("received notice of violation of this License (for any work) from that");
                    Console.WriteLine("copyright holder, and you cure the violation prior to 30 days after");
                    Console.WriteLine("your receipt of the notice.");
                    Console.WriteLine("");
                    Console.WriteLine("Termination of your rights under this section does not terminate the");
                    Console.WriteLine("licenses of parties who have received copies or rights from you under");
                    Console.WriteLine("this License.  If your rights have been terminated and not permanently");
                    Console.WriteLine("reinstated, you do not qualify to receive new licenses for the same");
                    Console.WriteLine("material under section 10.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("9. Acceptance Not Required for Having Copies.");
                    Console.WriteLine("");
                    Console.WriteLine("You are not required to accept this License in order to receive or");
                    Console.WriteLine("run a copy of the Program.  Ancillary propagation of a covered work");
                    Console.WriteLine("occurring solely as a consequence of using peer-to-peer transmission");
                    Console.WriteLine("to receive a copy likewise does not require acceptance.  However,");
                    Console.WriteLine("nothing other than this License grants you permission to propagate or");
                    Console.WriteLine("modify any covered work.  These actions infringe copyright if you do");
                    Console.WriteLine("not accept this License.  Therefore, by modifying or propagating a");
                    Console.WriteLine("covered work, you indicate your acceptance of this License to do so.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("10. Automatic Licensing of Downstream Recipients.");
                    Console.WriteLine("");
                    Console.WriteLine("Each time you convey a covered work, the recipient automatically");
                    Console.WriteLine("receives a license from the original licensors, to run, modify and");
                    Console.WriteLine("propagate that work, subject to this License.  You are not responsible");
                    Console.WriteLine("for enforcing compliance by third parties with this License.");
                    Console.WriteLine("");
                    Console.WriteLine("An 'entity transaction' is a transaction transferring control of an");
                    Console.WriteLine("organization, or substantially all assets of one, or subdividing an");
                    Console.WriteLine("organization, or merging organizations.  If propagation of a covered");
                    Console.WriteLine("work results from an entity transaction, each party to that");
                    Console.WriteLine("transaction who receives a copy of the work also receives whatever");
                    Console.WriteLine("licenses to the work the party's predecessor in interest had or could");
                    Console.WriteLine("give under the previous paragraph, plus a right to possession of the");
                    Console.WriteLine("Corresponding Source of the work from the predecessor in interest, if");
                    Console.WriteLine("the predecessor has it or can get it with reasonable efforts.");
                    Console.WriteLine("");
                    Console.WriteLine("You may not impose any further restrictions on the exercise of the");
                    Console.WriteLine("rights granted or affirmed under this License.  For example, you may");
                    Console.WriteLine("not impose a license fee, royalty, or other charge for exercise of");
                    Console.WriteLine("rights granted under this License, and you may not initiate litigation");
                    Console.WriteLine("(including a cross-claim or counterclaim in a lawsuit) alleging that");
                    Console.WriteLine("any patent claim is infringed by making, using, selling, offering for");
                    Console.WriteLine("sale, or importing the Program or any portion of it.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("11. Patents.");
                    Console.WriteLine("");
                    Console.WriteLine("A 'contributor' is a copyright holder who authorizes use under this");
                    Console.WriteLine("License of the Program or a work on which the Program is based.  The");
                    Console.WriteLine("work thus licensed is called the contributor's 'contributor version'.");
                    Console.WriteLine("");
                    Console.WriteLine("A contributor's 'essential patent claims' are all patent claims");
                    Console.WriteLine("owned or controlled by the contributor, whether already acquired or");
                    Console.WriteLine("hereafter acquired, that would be infringed by some manner, permitted");
                    Console.WriteLine("by this License, of making, using, or selling its contributor version,");
                    Console.WriteLine("but do not include claims that would be infringed only as a");
                    Console.WriteLine("consequence of further modification of the contributor version.  For");
                    Console.WriteLine("purposes of this definition, 'control' includes the right to grant");
                    Console.WriteLine("patent sublicenses in a manner consistent with the requirements of");
                    Console.WriteLine("this License.");
                    Console.WriteLine("");
                    Console.WriteLine("Each contributor grants you a non-exclusive, worldwide, royalty-free");
                    Console.WriteLine("patent license under the contributor's essential patent claims, to");
                    Console.WriteLine("make, use, sell, offer for sale, import and otherwise run, modify and");
                    Console.WriteLine("propagate the contents of its contributor version.");
                    Console.WriteLine("");
                    Console.WriteLine("In the following three paragraphs, a 'patent license' is any express");
                    Console.WriteLine("agreement or commitment, however denominated, not to enforce a patent");
                    Console.WriteLine("(such as an express permission to practice a patent or covenant not to");
                    Console.WriteLine("sue for patent infringement).  To 'grant' such a patent license to a");
                    Console.WriteLine("party means to make such an agreement or commitment not to enforce a");
                    Console.WriteLine("patent against the party.");
                    Console.WriteLine("");
                    Console.WriteLine("If you convey a covered work, knowingly relying on a patent license,");
                    Console.WriteLine("and the Corresponding Source of the work is not available for anyone");
                    Console.WriteLine("to copy, free of charge and under the terms of this License, through a");
                    Console.WriteLine("publicly available network server or other readily accessible means,");
                    Console.WriteLine("then you must either (1) cause the Corresponding Source to be so");
                    Console.WriteLine("available, or (2) arrange to deprive yourself of the benefit of the");
                    Console.WriteLine("patent license for this particular work, or (3) arrange, in a manner");
                    Console.WriteLine("consistent with the requirements of this License, to extend the patent");
                    Console.WriteLine("license to downstream recipients.  'Knowingly relying' means you have");
                    Console.WriteLine("actual knowledge that, but for the patent license, your conveying the");
                    Console.WriteLine("covered work in a country, or your recipient's use of the covered work");
                    Console.WriteLine("in a country, would infringe one or more identifiable patents in that");
                    Console.WriteLine("country that you have reason to believe are valid.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("If, pursuant to or in connection with a single transaction or");
                    Console.WriteLine("arrangement, you convey, or propagate by procuring conveyance of, a");
                    Console.WriteLine("covered work, and grant a patent license to some of the parties");
                    Console.WriteLine("receiving the covered work authorizing them to use, propagate, modify");
                    Console.WriteLine("or convey a specific copy of the covered work, then the patent license");
                    Console.WriteLine("you grant is automatically extended to all recipients of the covered");
                    Console.WriteLine("work and works based on it.");
                    Console.WriteLine("");
                    Console.WriteLine("A patent license is 'discriminatory' if it does not include within");
                    Console.WriteLine("the scope of its coverage, prohibits the exercise of, or is");
                    Console.WriteLine("conditioned on the non-exercise of one or more of the rights that are");
                    Console.WriteLine("specifically granted under this License.  You may not convey a covered");
                    Console.WriteLine("work if you are a party to an arrangement with a third party that is");
                    Console.WriteLine("in the business of distributing software, under which you make payment");
                    Console.WriteLine("to the third party based on the extent of your activity of conveying");
                    Console.WriteLine("the work, and under which the third party grants, to any of the");
                    Console.WriteLine("parties who would receive the covered work from you, a discriminatory");
                    Console.WriteLine("patent license (a) in connection with copies of the covered work");
                    Console.WriteLine("conveyed by you (or copies made from those copies), or (b) primarily");
                    Console.WriteLine("for and in connection with specific products or compilations that");
                    Console.WriteLine("contain the covered work, unless you entered into that arrangement,");
                    Console.WriteLine("or that patent license was granted, prior to 28 March 2007.");
                    Console.WriteLine("");
                    Console.WriteLine("Nothing in this License shall be construed as excluding or limiting");
                    Console.WriteLine("any implied license or other defenses to infringement that may");
                    Console.WriteLine("otherwise be available to you under applicable patent law.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("12. No Surrender of Others' Freedom.");
                    Console.WriteLine("");
                    Console.WriteLine("If conditions are imposed on you (whether by court order, agreement or");
                    Console.WriteLine("otherwise) that contradict the conditions of this License, they do not");
                    Console.WriteLine("excuse you from the conditions of this License.  If you cannot convey a");
                    Console.WriteLine("covered work so as to satisfy simultaneously your obligations under this");
                    Console.WriteLine("License and any other pertinent obligations, then as a consequence you may");
                    Console.WriteLine("not convey it at all.  For example, if you agree to terms that obligate you");
                    Console.WriteLine("to collect a royalty for further conveying from those to whom you convey");
                    Console.WriteLine("the Program, the only way you could satisfy both those terms and this");
                    Console.WriteLine("License would be to refrain entirely from conveying the Program.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("13. Use with the GNU Affero General Public License.");
                    Console.WriteLine("");
                    Console.WriteLine("Notwithstanding any other provision of this License, you have");
                    Console.WriteLine("permission to link or combine any covered work with a work licensed");
                    Console.WriteLine("under version 3 of the GNU Affero General Public License into a single");
                    Console.WriteLine("combined work, and to convey the resulting work.  The terms of this");
                    Console.WriteLine("License will continue to apply to the part which is the covered work,");
                    Console.WriteLine("but the special requirements of the GNU Affero General Public License,");
                    Console.WriteLine("section 13, concerning interaction through a network will apply to the");
                    Console.WriteLine("combination as such.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.WriteLine("14. Revised Versions of this License.");
                    Console.WriteLine("");
                    Console.WriteLine("The Free Software Foundation may publish revised and/or new versions of");
                    Console.WriteLine("the GNU General Public License from time to time.  Such new versions will");
                    Console.WriteLine("be similar in spirit to the present version, but may differ in detail to");
                    Console.WriteLine("address new problems or concerns.");
                    Console.WriteLine("");
                    Console.WriteLine("Each version is given a distinguishing version number.  If the");
                    Console.WriteLine("Program specifies that a certain numbered version of the GNU General");
                    Console.WriteLine("Public License 'or any later version' applies to it, you have the");
                    Console.WriteLine("option of following the terms and conditions either of that numbered");
                    Console.WriteLine("version or of any later version published by the Free Software");
                    Console.WriteLine("Foundation.  If the Program does not specify a version number of the");
                    Console.WriteLine("GNU General Public License, you may choose any version ever published");
                    Console.WriteLine("by the Free Software Foundation.");
                    Console.WriteLine("");
                    Console.WriteLine("If the Program specifies that a proxy can decide which future");
                    Console.WriteLine("versions of the GNU General Public License can be used, that proxy's");
                    Console.WriteLine("public statement of acceptance of a version permanently authorizes you");
                    Console.WriteLine("to choose that version for the Program.");
                    Console.WriteLine("");
                    Console.WriteLine("Later license versions may give you additional or different");
                    Console.WriteLine("permissions.  However, no additional obligations are imposed on any");
                    Console.WriteLine("author or copyright holder as a result of your choosing to follow a");
                    Console.ReadLine();
                }
                else if(input == "show w")
                {
                    Console.WriteLine("  15. Disclaimer of Warranty.");
                    Console.WriteLine("  THERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMITTED BY");
                    Console.WriteLine("APPLICABLE LAW.  EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT");
                    Console.WriteLine("HOLDERS AND/OR OTHER PARTIES PROVIDE THE PROGRAM 'AS IS' WITHOUT WARRANTY");
                    Console.WriteLine("OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO,");
                    Console.WriteLine("THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR");
                    Console.WriteLine("PURPOSE.  THE ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM");
                    Console.WriteLine("IS WITH YOU.  SHOULD THE PROGRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF");
                    Console.WriteLine("ALL NECESSARY SERVICING, REPAIR OR CORRECTION.");
                    Console.WriteLine(" ");
                    Console.WriteLine("  17. Interpretation of Sections 15 and 16.");
                    Console.WriteLine("  IN NO EVENT UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING");
                    Console.WriteLine("WILL ANY COPYRIGHT HOLDER, OR ANY OTHER PARTY WHO MODIFIES AND/OR CONVEYS");
                    Console.WriteLine("THE PROGRAM AS PERMITTED ABOVE, BE LIABLE TO YOU FOR DAMAGES, INCLUDING ANY");
                    Console.WriteLine("GENERAL, SPECIAL, INCIDENTAL OR CONSEQUENTIAL DAMAGES ARISING OUT OF THE");
                    Console.WriteLine("USE OR INABILITY TO USE THE PROGRAM (INCLUDING BUT NOT LIMITED TO LOSS OF");
                    Console.WriteLine("DATA OR DATA BEING RENDERED INACCURATE OR LOSSES SUSTAINED BY YOU OR THIRD");
                    Console.WriteLine("PARTIES OR A FAILURE OF THE PROGRAM TO OPERATE WITH ANY OTHER PROGRAMS),");
                    Console.WriteLine("EVEN IF SUCH HOLDER OR OTHER PARTY HAS BEEN ADVISED OF THE POSSIBILITY OF");
                    Console.WriteLine("SUCH DAMAGES.");
                    Console.ReadLine();
                }
                else;
                {
                    Console.WriteLine("This is a program written in C# that shows just how fast it is.");
                    Console.Write("press enter to start the program.");
                    Console.ReadLine();
                    Bat(repeat);
                }
            }
        }

        static void Bat(int m)
        {
            int repeat = 0;
            int newline = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            do
            {
                if (newline > 5)
                {
                    Console.WriteLine(repeat + " ");
                    newline = 0;
                    repeat++;
                    if (repeat > 1000000)
                    {
                        break;
                    }
                    else;
                    {
                    }
                }
                else
                {
                    Console.Write(repeat + " ");
                    newline++;
                    repeat++;
                    if (repeat > 1000000)
                    {
                        break;
                    }
                    else;
                    {
                    }
                }
            }
            while (repeat <= 1000000);
            if(repeat >= 1000001)
            {
                TimeSpan goneby = stopWatch.Elapsed;
                stopWatch.Stop();
                string time = String.Format("{0:00}:{1:00}.{2:00}",
                    goneby.Minutes, goneby.Seconds,
                    goneby.Milliseconds / 10);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("It took " + time + " to finish the program");
                Console.WriteLine(" ");
                Console.WriteLine("it just repeated 1,000,000 times.");
                Console.WriteLine("if you think that is slow, why don't you type the numbers 1 - 1,000,000?");
                Console.Write("press enter to exit the program.");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
        }
    }
}