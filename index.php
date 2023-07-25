<!doctype HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html lang="en">
<!-- Created By: Glen Bahr -->
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
  <title>Mohawk Valley Soccer Referee Association (MVSRA)</title>
  <meta name="description" content="MVSRA &mdash; USSF Affiliate in the Mohawk Valley">
  <meta name="keywords" content="Mohawk Valley Soccer Referee Association, MVSRA, M.V.S.R.A., U.S.S.F., USSF, soccer, referee, Oneida County, Utica, Rome">
  <meta name="author" content="Glen Bahr">
  <meta name="generator" content="AceHTML 6 Pro">

<style type="text/css">
<!--
h1 { color:green; font-family:impact }
h2 {color: white; font-family: Arial}
p {font-family: arial}
td {font-family: arial}
-->
</style>

<?php
$dir = "Images/";
$a = scandir($dir);	//find all the files and directories in $dir
$int = 0;
foreach ($a as $filename)
	{
	if (stristr("$filename",".jpg")) //ignore non-JPG names
		{
		$pic[$int]=$filename;	//assign all filenames to array $pic[ ]
		$int++;
		}
	}
?>

<script type="text/javascript">
/***********************************************
* Ultimate Fade-In Slideshow (v1.5): © Dynamic Drive (http://www.dynamicdrive.com)
* This notice MUST stay intact for legal use
* Visit http://www.dynamicdrive.com/ for this script and 100s more.
***********************************************/
 
// Actual Image data follows:
//Use 400 x 400 px for images.
	var fadeimages=new Array(
		<?php	
		foreach ($pic as $filename)
			{
			echo '["' . $dir . $filename . '", "", ""]';	// Creates array records, each in this format: ["Images/filename.jpg", "", ""],
			if ($filename <> $pic[count($pic)-1]) // Adds comma, except after last record
				{
				echo ",";
				}
			}
		?>	
		)

	var fadebgcolor="black"

<?php
include ("SlideShowFixedScript.js"); //be sure to upload this file.
?>
</script>

</head>

<body alink="#ff0000" bgcolor="#000000" link="#00ff00" text="#ffffff" vlink="#ffa500">
<?php //These variables obfuscate portions of the EMail addrs to reduce spam
$mailto="mailto:";
$ATmvsra_org="@mvsra.org";
$title="title='Send an email to MVSRA ";
$title_excused="title='Send request to be excused to MVSRA Secretary ";
?>
<table align="center" border=0 summary="">
	<tr>
		<td style="padding-right: 1em; text-align: center"><img src="Images/Graphics/mvsralogo.png" width="250" height="250" alt="MVSRA Logo" border="0"></td>
		<td style="padding-right: 1em; color: #FFCC33" rowspan="2">
	 		<p align="center">
		
		<script type="text/javascript">
	//new fadeshow(IMAGES_ARRAY_NAME, slideshow_width, slideshow_height, borderwidth, delay, pause (0=no, 1=yes), 
	//    optionalRandomOrder ("R" to randomize, remove this parameter to not))
	//    nonRandomized = alphanumeric sort with Capital Letters sorting ahead of Lower Case)
	//Add 12 px to both width and height to accommodate the image border 
	//Smaller images do NOT refresh the pixels used by larger images, so it works best to resize the images to one size.
	var DelayTime=2 //Time for each image, seconds 
	DelayTime=1000*DelayTime
	new fadeshow(fadeimages, 400, 400, 0, DelayTime, 1, "R")
		//array=fadeimages, 400 wide, 400 high, no border, delay=2 sec, pause ON, random ON.
</script>
<p style="font-size: small; text-align: center">
Rotating images may be frozen<br>by passing your mouse over them.</p>
		</td>
	</tr>
	<tr>
		<td style="padding-right: 1em"><p align="center" style="color: #FFCC33; font-size: 200%">Mohawk Valley<br>Soccer Referee Association<br> (MVSRA)</p></td>
	</tr>
</table><br>

<table border="0" align="center" style="border: thick ridge silver" width="85%">
<!-- =========== NEXT MEETING: =========== -->
	<tr>
		<td style="border: thin solid yellow; padding: 3em 1em 1em 1em; vertical-align: top width: 14em" id="Meetings">
			Next Meeting(s):
		</td>
		<td style="border: thin solid yellow; padding: 1em 1em 1em 1em" colspan="2">
<!--
			<p style="color: yellow; font-style: italic; font-variant: small-caps">Executive Committee:</p>
			<i>Date:</i> March 3, 2016 <br>
			<i>Time:</i> 6:00 - 8:00 PM <br>
			<i>Location:</i> Rising Stars Sports Center <br> 
			<i>Who:</i> Executive Committee Members <br>
			<i>Agenda:</i> See Email<br>
			<br><hr></hr><br>
 -->

			<p style="color: yellow; font-style: italic; font-variant: small-caps">General Membership:</p>
			<b><i>Date:</i> Thursday, November 16, 2023<br>
			<i>Time:</i> <font color="#ff00ff"><b><blink>6:00 PM</blink></b></font> <br>
			<i>Location:</i> <a href="http://g.co/maps/kbsn5" target="_blank"><!-- St. Thomas Parish Center --></a>TBD <br> 
			<i>Who:</i>
			<ul compact type="disc" style="margin-top: 0em; margin-bottom: 0em">
				<li>All Members </li>
				<li>Prospective Referees</li>
			</ul>
			<i>Agenda:</i>
			<ul compact type="disc" style="margin-top: 0em; margin-bottom: 0em">
				<li>Business Meeting</li>
			</ul>
		</td>
	</tr>

<!-- =========== HOT INFO: =========== -->
	<tr style="font-size: larger">
		<td style="border: thin solid red; padding: 3em 1em 1em 1em; vertical-align: top" width="100em" rowspan="5">
			Hot Info:
		</td>

<!-- =========== HOW TO BECOME A US SOCCER REFEREE =========== -->
	<tr style="font-size: larger">
		<td style="border: thin solid red; padding: 1em 1em 1em 1em; color: #FF7A7A" colspan="2">
			<p><b><u><i>How to Become a US Soccer Referee</i></u> &mdash;</b></p>
			<p>Guidance for becoming a US Soccer Referee is provided on the web site of our regional organization, Eastern New York Soccer Referee Association. If you might like to become a soccer referee or know someone who would, please follow the information at this link:</p>
			<p><a href="https://enysreferee.org/how-to-become-a-referee/?fbclid=IwAR2vjRAkQSB7GstjKfhWyklT8kl1g-S028zXHT5HIAcfm0JHWQJB6scZIno" target="_blank">Eastern New York's "Become a US Soccer Referee"</a></p>
<!-- =========== NEW REFEREE CLASS =========== -->
	<tr style="font-size: larger">
		<td style="border: thin solid red; padding: 1em 1em 1em 1em; color: #FF7A7A" colspan="2">
			<p><b><u><i>New Soccer Referee Classes for 2023</i></u> &mdash;</b></p>
			<!-- <p>When possible we will announce training classes here and by email to those who have signed up as follows: We NEED more referees in MVSRA, so if you are interested in becoming a soccer referee, please <a href="mailto:Info<?php echo $ATmvsra_org;?>?subject=New Referee Class Interest&body=Please keep me informed of upcoming Entry Level Soccer Referee Training opportunities sponsored by MVSRA.%0A%0AName: _________%0APhone: _________" title='Send an email to MVSRA' >E-mail us</a> now so we can contact you with Class Registration details as soon as they are available.</p>
		<p>Members, please spread the word and help us recruit prospective referees!</p> -->

 			<p>Click the image below to see a full size view of the announcement.</p>
			<p style="text-align: center"><a href="new soccer ref class flyer.pdf" target="_blank"><img src="new soccer ref class flyer thumb.png" width="300" height="232" border="0"></a></p>
			<p>So you don't have to type the link printed on the announcement, just click here:<br>
			<a href="https://enysreferee.org/how-to-become-a-referee/">https://enysreferee.org/how-to-become-a-referee/</a>
			</p>

<!-- 
			<p>Click NOW for instructions on signing up: <a href="MVSRA Referee Course Registration.docx" target="_blank">MVSRA Referee Course Registration</a></p>
 
			<p>Classes will begin on Saturday, April 6:<br><br>
			<i>Dates:</i> Saturdays - April 6, April 13, (NOT April 20), April 27, and May 4<br>
			<i>Time:</i> 9:00 AM &mdash; 1:00 PM <br>
			<i>Location:</i> <a href="https://goo.gl/maps/tuXbTvPTDAs" target="_blank">Mohawk Valley Community Action Agency, Inc.</a>, 9882 River Road, Utica NY<br> 
			<i>Cost:</i> $180 (includes course, 2019 registrations, and 8-piece uniform package)<br>
			<i>Confirm:</i> <b><i>Please confirm</i></b> that you plan to attend these sessions. Send <a href="mailto:Instructor@mvsra.org?subject=New Referee Class&body=I will attend the upcoming Entry Level Soccer Referee Training classes that begin April 6." title='Send an email to MVSRA' >E-mail to the MVSRA Referee Trainer</a>.<br><br>
			<i>Fee Payment:</i> Please submit the class fee on-line <a href="MVSRA_RefClass_payment.php" target="_blank">here</a>.
			</p>
 -->

 		</td>
	</tr>
<!-- =========== ON-LINE DUES PAYMENT =========== -->
	<tr style="font-size: larger">
		<td style="border: thin solid red; padding: 1em 1em 1em 1em; color: #FF7A7A" colspan="2">
			<p><b><u><i>Local Dues Payment for This Year</i></u> &mdash;</b></p>
			<p>You are encouraged to pay your local MVSRA dues on-line here using PayPal or a credit card. Click the link here and a new window will open that explains the process to pay your dues:</p>
				<ul type="disc">
					<li><b><a href="MVSRA_dues_payment.php" target="_blank" style="color: #FFA6A6">Click to Pay MVSRA Dues</a></b></li>
				</ul>
		</td>
	</tr>
<!-- =========== REFEREE REGISTRATION =========== -->
	<tr style="font-size: larger">
		<td style="border: thin solid red; padding: 1em 1em 1em 1em; color: #FF7A7A" colspan="2">
			<p><b><u><i>ENY Registration</i></u> &mdash;</b></p>
			<p>Registration for the year is on-line at <a href="https://enysreferee.org/recertifiction/" target="_blank" style="color: limegreen">the ENYSRA Site</a>. On that page you'll find detailed instructions.</p>
			<p>Remember to also pay your Local Dues as outlined above.</p>
			<!-- <p style="color: lime"><font size="+2" color="lime">Registration Instructions for 2020 are Under Construction!</font><br>We do not have valid enysra.gameofficials.net guidance to share with you, but will provide it here as soon as it is available. Please come back in a few days.</p>
<p>In the meantime, you can start the process by completing your SafeSport training. Access the online training by following this link: <a href="http://safesport.org/authentication/register?token=ee57337f-31f9-421d-b095-82fc8c8c4c41" target="_blank">http://safesport.org/authentication/register?token=ee57337f-31f9-421d-b095-82fc8c8c4c41</a>.  It is about 90 minutes long and is free utilizing access code YC3E-6P5G-YYIL-CS2M.</p> -->

		</td>
	</tr>

<!-- CURRENT YEAR'S MEETINGS: -->
	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top; width: 15%">
			<p>Meetings:</p>
			<p style="font-style: italic; font-size: smaller">(Click for Minutes)</p>
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2">
			<!-- <b><?php echo date("Y"); ?>:</b> <font size="-1"><i>(Unless noted, all meetings this year will be at <a href="http://g.co/maps/kbsn5" target="_blank">St. Thomas Parish Center</a>)</i></font><br> -->
			<div style="margin-left: 0.25in"><!-- Indent all the meeting lines -->
					<a href="Minutes/Minutes_2023_03_05.pdf" target="_blank">Sunday, March 5, 6:00 PM</a><br>
					<a href="Minutes/Minutes_2023_04_16.pdf" target="_blank"></a>Sunday, April 16, 6:00 PM <font color="RED">CANCELED</font><br>
					<a href="Minutes/Minutes_2023_05_07.pdf" target="_blank">Sunday, May 7, 6:00 PM</a><br>
					<a href="Minutes/Minutes_2023_06_15.pdf" target="_blank">Thursday, June 15, 6:00 PM</a><br>
					<a href="Minutes/Minutes_2023_07_13.pdf" target="_blank"></a>Thursday, July 13, 6:00 PM<br>
					<a href="Minutes/Minutes_2023_11_16.pdf" target="_blank"></a>Thursday, November 16, 6:00 PM	(Election of Officers)
			</div>

<!-- LAST YEAR'S MEETINGS: -->
			<div style="font-size: small; color: gray; padding-top: 1em">
				<b><?php echo date("Y")-1; ?>:</b><br>
				<div style="margin-left: 0.25in"><!-- Indent all the meeting lines -->
					<a href="Minutes/Minutes_2022_03_03.pdf" target="_blank">Thursday, March 3, 6:00 PM</a><br>
					<a href="Minutes/Minutes_2022_04_07.pdf" target="_blank">Thursday, April 7, 6:00 PM</a><br>
					<a href="Minutes/Minutes_2022_05_05.pdf" target="_blank"></a>Thursday, May 5, 6:00 PM<br>
					<a href="Minutes/Minutes_2022_06_09.pdf" target="_blank"></a>Thursday, June 9, 6:00 PM<br>
					<a href="Minutes/Minutes_2022_07_07.pdf" target="_blank">Thursday, July 7, 6:00 PM</a><br>
					<a href="Minutes/Minutes_2022_08_04.pdf" target="_blank"></a>Thursday, August 4, 6:00 PM &ndash; Canceled<br>
					<a href="Minutes/Minutes_2022_11_17.pdf" target="_blank"></a>Thursday, November 17, 6:00 PM
				</div>
			</div> 
		</td>
	</tr>
	<!-- AVAILABILITY: -->
	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top">
			Enter Your <br>Availability:
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2">
			<p>IMPORTANT: Dues must be paid to be eligible for games.</p>
			<p><a href="https://www.arbitersports.com/sign-in" target="_blank">ENTER AVAILABILITY</a></p>
			<p>For the outdoor season, our Assignor needs your availability for weekends, as well as weekday evenings. You may simply block all day when you are not available on a weekday evening. While you may indicate nonavailability as far in the future as known, <i>please be sure that your calendar is always up-to-date for the next two weeks.</i></p>
		</td>
	</tr>
	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top"><a name="Uniforms"></a>
			Uniforms and <br>Referee Gear:
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2">
			<p><a href="http://finaldecision.net" target="_blank">Final Decision</a></p>
			<p><a href="http://www.officialsports.com" target="_blank">Official Sports International</a> (probably the most popular)</p>
			<p><a href="http://www.scoresports.com/index.php" target="_blank">Score Soccer</a></p>
			<p><a href="https://www.refereestore.com" target="_blank">Referee Store</a></p>			
		</td>
	</tr>
	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top">
			<p>Game Reports</p>
			<p style="text-indent: 1em">and other</p>
			<p>Useful Forms:</p>
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2">
			<p><a href="CR2AR.pdf">Pre-Game Conference</a></p>
   <?php
   $ReportBody="
   ?subject=League-Game#-REF_Initials&amp;body=
	 	(Update subject line above with actual info, so it looks something like 'CNYSSL-6175-KH', which also is the name of the game report file that you will attach to this email.)%0A
		Game Date: _____%0A
		Final Score:%0A
		    TeamNameA - _____%0A
		    TeamNameB - _____%0A
		Misconducts: (enter a number as appropriate)%0A
		     No Cautions%0A
		     No Send Offs%0A
		     No Dismissals%0A
		Other Issues:%0A
		     None%0A%0A
		Referee: _____"
   ?>
			<p><a name="GameReporting"></a><b>Game Reporting Procedures for MVSRA Referees --</b></p>
			<table border="0" style="margin-left: 2em; margin-top: -1em">
				<tr>
					<td>
						<!-- DELETE THIS WHOLE SECTION??? MAYBE...    
						<ul type="disc">
							<li style="margin-top: 0.4em"><b>CNYSSL and Other Games</b>
                    &mdash; Download blank Generic USSF Game Report:<br> 
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<a href="Reports/2012 Generic - USSF Referee Game Report.doc">MS Word version</a> or 
						<a href="Reports/US_Soccer_Referee_Report_060612.pdf" target="_blank">PDF version</a><br> 
					and, if needed, blank Supplemental Report:<br>
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<a href="Reports/2012 Generic - USSF Supplemental Referee Report.doc">MS Word version</a> or
						<a href="Reports/US_Soccer_Supplemental_Referee_Report_060612.pdf" target="_blank">PDF version</a><br>
                    <font color="#00ffff"><i>
						Save game reports under a filename structured like: <br>
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>League &ndash; Game# &ndash; Ref Initials</b>, <br>
						for example,<br>
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>CNYSSL&ndash;54321&ndash;ALD</b> &nbsp;&nbsp;&nbsp;&nbsp;or&nbsp;&nbsp;&nbsp;&nbsp; <b>RSSC&ndash;54321&ndash;KW</b><br><br>
						(USSF report forms dated 2012 are still current.)</i></font><br><br>
                    &mdash; CNYSSL Reports &ndash; See <a href="CNYSSL/League Info.docx" target="_blank">CNYSSL League Info</a> to report Red Cards <b>the SAME NIGHT as the game</b>. Send normal game reports as attachments to <a href="<?php echo $mailto.'CNYSSL-GR'.$ATmvsra_org.$ReportBody;?>" 
                    title="Insert League name and game number in Subject Line">CNYSSL-GR@mvsra.org</a><br>
                    
                    &mdash; All other Reports &ndash; Send as attachments to <a href="<?php echo $mailto.'GR'.$ATmvsra_org.$ReportBody;?>" 
                    title="Insert game number in Subject Line"><?php echo 'GR'.$ATmvsra_org?></a><br>&nbsp;
							</li> -->

							<li style="margin-top: 0.4em"><b>For all games:</b><br>
							&mdash; USSF Guidance for Game Report Writing <a href="Game Report Writing.pdf" target="_blank">PDF version</a><br>
							&mdash;<i> All Game Reports are due within <b>48 hours</b> after the game</i>.<br>
							&mdash; Place the following information in the body of all game report Emails:<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &diams; Game Number<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &diams; Game Date<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &diams; Number of Cautions<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &diams; Number of Send-offs<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &diams; Number of Dismissals<br>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &diams; Other Issues
							
							<!-- <a href="Reports/MVSRA 2014 Game Report ProcedureUH.pdf">Click here</a> for more detailed reporting guidance. -->
                    </li>

							<li style="margin-top: 0.4em"><b>Supplemental Reports.</b> <br>If you include a Supplemental Report, mark your email as "High Importance" or "Priority". <br>A Supplemental Report is required for any of the following incidents:<br>
									&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; Send Off<br>
									&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; Team Official (coach, assistant coach, manager, etc.) Dismissal<br>
									&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; Injury<br>
									&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; Spectator Interference<br>
									&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; Any Other Incident requiring an explanation or a drawing
							</li>

							<li>
								<p style="text-align: left">Click for the PDF:&nbsp;&nbsp;&nbsp;<a href="Referee Assault Procedure for 2018.pdf" target="_blank"><img src="Referee Assault Procedure for 2018_thumb.png" height="120" border="0" style="vertical-align: middle" alt="Ref Assault Procedure thumbnail"></a></p>
							</li>
						</ul>
					</td>
				</tr>
			</table>
			<p><a href="CNYSSL_crd.pdf">CNYSSL Score Card</a></p>
			<p><a href="MVSRA Voucher BLANK.doc">MVSRA Expense and Service Voucher</a></p>
		</td>
	</tr>

	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top">
			Leagues:
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2"><a id="Leagues"></a><!-- Put the id in the 2nd column because it has less padding. -->
			<p><a href="https://thruway.wnyreferee.org/" target="_blank">The Thruway League</a></p>
			<p><a href="https://nwc.wnyreferee.org/" target="_blank">NYW Champions Conference</a></p>
			<p><a href="https://dpleague.org/" target="_blank">Development Player League (DPL)</a></p>
			<p><a href="https://www.elevatecny.com/" target="_blank">Elevate CNY Sports Complex</a></p>
			<p><a href="http://www.ayso.org" target="_blank">AYSO</a><br>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; <a href="http://www.aysou.org" target="_blank">AYSO U</a> on-line learning resources<br>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; <a href="http://www.aysosection3.org" target="_blank">AYSO Section 3</a><br>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&mdash; <a href="AYSO/AYSO National-Rules-Regulations.pdf" target="_blank">AYSO National
Rules & Regulations</a></p>
		</td>
	</tr>
	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top">

			Special Links:
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2"><a name="Special_Links"></a>
			<p style="text-indent: -1em; margin-left: 1em"><font style="color: red; font-style: italic; font-variant: small-caps; font-weight: bold; font-size: larger">Laws of  the Game:</font> <br>
			Current LOTG are available from the IFAB web site &mdash; <a href="https://www.theifab.com/log-documents" target="_blank">Laws of the Game (LOTG)</a>. Not only will you find the new LOTG, but the <a href="https://theifab.com/presentation-of-ifab-log-2020-21/" target="_blank">"Presentation of all changes to the Laws and clarifications"</a> includes video examples. Check it out!</p>
			<p><a name="NewInfo"></a><a href="http://soccerrefereeusa.com/index.php/referee-library" name="RefereeLibrary" target="_blank">Referee Library</a>. This library at SoccerRefereeUSA.com has current copies of many other resources you may need, including:
			<dl style="margin-left: 2em">
				<dt>Match Reporting:</dt>
					<dd>
					<ul type="disc">
						<li>USSF Referee Report</li>
						<li>USSF Supplemental Referee Report</li>
						<li>USSF 4th Official Game Log</li>
						<li>Kicks From The Penalty Mark - Score Sheets</li>
					</ul>
					</dd>
				<dt>Other Documents related to the Laws of  the Game:</dt>
					<dd>
					<ul type="disc">
						<li>Advice to Referees</li>
						<li>Guide to Procedures</li>
						<li>7+7 Cautionable and Sending Off Offenses</li>
						<li>Offside Made Easy</li>
						<li>Information For New Referees</li>
						<li>USSF Referee Assault/Abuse Policy</li>
						<li>"The Rectangle" - new USSF alternative to "Diagonal System"</li>
					</ul>
					</dd>
				<dt>USSF Directives:</dt>
					<dd>
					<ul type="disc">
						<li>100% Misconduct</li>
						<li>Assistant Referee Involvement</li>
						<li>Contact Above the Shoulder</li>
						<li>Dissent</li>
						<li>Free Kick and Restart Management</li>
						<li>Game Disrepute and Mass Confrontation</li>
						<li>Game Management Model-Flow Risk Taking Game Control</li>
						<li>Handling the Ball</li>
						<li>Injury Management</li>
						<li>Managing the Technical Area</li>
					</ul>
					</dd>
				<dt>and Much More</dt>
			</dl>
			<p><a href="http://soccerrefereeusa.com/index.php/referee-testing" target="_blank">Test Your Knowledge of the Game</a>. SoccerRefereeUSA.com has over 40 timed quizzes with references to the answers in LOTG, ATR, GTP, INT, etc.</p>
			<p><a name="Kicks" href="Training/Law 14 Checklist for Kicks from the Penalty Mark.pdf">Law 14 Checklist for Kicks from the Penalty Mark</a>. This checklist of responsibilities, guidelines, and procedures is provided	as a useful single source of guidance for referees who need to conduct the process of Kicks from the Penalty Mark. <a href="Kicks from the Penalty Mark scorecard.pdf">Kicks from the Penalty Mark scorecard</a></p>
			<p>4th Official Procedures &mdash; <a href="Training/Managing the Technical Area.pdf" target="_blank">Managing the Technical Area</a>.</p>
			<p><a href="Information_for_New_Referees_2010.pdf">Game Management for Referees</a> - What's a ref supposed to do: A USSF handbook on how to apply the LOTG</p>
			<p><a href="RefEthics.html">Code of Ethics for Referees</a> and <a href="Training/Ethics Training.pdf" target="_blank">USSF Referee Code of Ethics training</a></p>
			<p><a href="FitnessTest.pdf">Physical Fitness Test</a></p>
			<p><a href="Bylaws.pdf" target="_blank">MVSRA Bylaws</a> <b><i><font color="red">AMENDED!</font></i></b></p>
			<p><a href="https://enysreferee.org/" target="_blank">Eastern New York Soccer Referees</a></p>
			<p><a href="RefAssaultProcedure.pdf" target="_blank">Eastern New York Soccer Referee Assault Procedure</a> <b><i><font color="red">NEW!!</font></i></b></p>
			<p><a href="http://www.usasa.com" target="_blank">US Adult Soccer Association</a></p>
			<p><a href="http://www.ussoccer.com" target="_blank">USSF (US Soccer)</a> New and Improved!</p>
			<p><a href="http://www.fifa.com" target="_blank">FIFA</a></p>
			<p style="text-align: center"><a href="http://www.wunderground.com/US/NY/Utica.html" target="_blank">
<img src="http://banners.wunderground.com/banner/infobox_both/US/NY/Utica.gif" alt="Click for Utica, NY Forecast" height=108 width=144></a></p>
		<!-- </td>
		<td style="border: thin solid gray; padding: 2em 1em 1em 1em; vertical-align: top; width: 10%" align="center">
			<iframe src="http://www.facebook.com/plugins/likebox.php?href=http%3A%2F%2Fwww.facebook.com%2Fpages%2FMohawk-Valley-Soccer-Referee-Association%2F102237589843226%3Fv%3D
				page_getting_started%23%21%2Fpages%2FMohawk-Valley-Soccer-Referee-Association%2F102237589843226%3Fv%3Dwall&amp;
				width=292&amp;colorscheme=dark&amp;connections=10&amp;stream=true&amp;header=true&amp;height=587" scrolling="no" frameborder="0" style="border:none; overflow:hidden; width:292px; height:587px;">
			</iframe> -->
		</td>
	</tr>
	<tr>
		<td style="border: thin solid gray; padding: 3em 1em 1em 1em; vertical-align: top">
			MVSRA<br><font style="padding-left: 2em">Officers:</font></font>
		</td>
		<td style="border: thin solid gray; padding: 1em 1em 1em 1em" colspan="2">
			<table border=0 summary="">
				<tr>
					<td style="font-style: oblique">President &ndash;&nbsp;</td>
					<td>Kit Hutchinson</td>
				</tr>
                
				<tr>
					<td style="font-style: oblique">Vice President &ndash;&nbsp;</td>
					<td>Mike Popowski</td>
				</tr>
        
				<tr>
					<td style="font-style: oblique">Secretary &ndash;&nbsp;</td>
					<td></td>
				</tr>
				
				<tr>
					<td style="font-style: oblique">Treasurer &ndash;&nbsp;</td>
					<td>Bjorn Solli</td>
				</tr>
				
				<tr>
					<td style="font-style: oblique">Assignor &ndash;&nbsp;</td>
					<td>Kevin Waters</td>
				</tr>
				
<!-- 
				<tr>
					<td style="font-style: oblique">Registrar &ndash;&nbsp;</td>
					<td>Bill Bailey</td>
				</tr> -->

			</table>
		</td>
	</tr>
</table>

<p style="text-align: center">Thank you for visiting our Referee page. Please come back and visit again!</p>

<div style="text-align: center; font-size: smaller">
<p style="font-style: italic">
<script type="text/JavaScript" language="JavaScript" src="LastUpdated.js"></script></p>
<p>

<p><a onclick="window.open('Copyright.html', 'Copyright', 'width=600, height=410, resizable=yes'); return false;"
	href="Copyright.html">&copy; Copyright <?php echo date("Y"); ?> <br>Mohawk Valley Soccer Referee Association	(MVSRA)
</a></p>
</div>

</body>
</html>
