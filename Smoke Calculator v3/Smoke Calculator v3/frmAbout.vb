﻿Public Class frmAbout

     Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
          Me.Close()

     End Sub

     Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Dim xv As String = My.Application.Info.Version.ToString
          bVersion.Text = "v" & xv
        bCopyright.Text = "© 2022 Scott Reed"
        bSupport.Text = "mreed1972@gmail.com"

          bQuote.Text = qte()
     End Sub



     Private Function qte()
        Dim RDQ() As String = {"Love For All, Hatred For None. – Khalifatul Masih III", "Change the world by being yourself. – Amy Poehler", "Every moment is a fresh beginning. – T.S Eliot",
                                 "Never regret anything that made you smile. – Mark Twain", "Die with memories, not dreams. – Unknown", "Aspire to inspire before we expire. – Unknown",
                                 "Everything you can imagine is real. – Pablo Picasso", "Simplicity is the ultimate sophistication. – Leonardo da Vinci", "Whatever you do, do it well. – Walt Disney",
                                 "What we think, we become. – Buddha", "All limitations are self-imposed. – Oliver Wendell Holmes", "Tough times never last but tough people do. – Robert H. Schiuller",
                                 "Problems are not stop signs, they are guidelines. – Robert H. Schiuller", "One day the people that don’t even believe in you will tell everyone how they met you. – Johnny Depp",
                                 "If I’m gonna tell a real story, I’m gonna start with my name. – Kendrick Lamar", "If you tell the truth you don’t have to remember anything. – Mark Twain",
                                 "Have enough courage to start and enough heart to finish. – Jessica N. S. Yourko", "Hate comes from intimidation, love comes from appreciation. – Tyga",
                                 "I could agree with you but then we’d both be wrong. – Harvey Specter", "Oh, the things you can find, if you don’t stay behind. – Dr. Seuss",
                                 "Determine your priorities and focus on them. – Eileen McDargh", "Be so good they can’t ignore you. – Steve Martin", "Dream as if you’ll live forever, live as if you’ll die today. – James Dean",
                                 "Yesterday you said tomorrow. Just do it. – Nike", "I don’t need it to be easy, I need it to be worth it. – Lil Wayne", "Never let your emotions overpower your intelligence. – Drake",
                                 "Nothing lasts forever but at least we got these memories. – J. Cole", "Don’t you know your imperfections is a blessing? – Kendrick Lamar", "Reality is wrong, dreams are for real. – Tupac",
                                 "To live will be an awfully big adventure. – Peter Pan", "Try to be a rainbow in someone’s cloud. – Maya Angelou", "There is no substitute for hard work. – Thomas Edison", "What consumes your mind controls your life- Unknown",
                                 "Strive for greatness. – Lebron James", "Wanting to be someone else is a waste of who you are. – Kurt Cobain", "And still, I rise. – Maya Angelou", "The time is always right to do what is right. – Martin Luther King Jr",
                                 "Let the beauty of what you love be what you do. – Rumi", "May your choices reflect your hopes, not your fears. – Nelson Mandela", "A happy soul is the best shield for a cruel world. – Atticus",
                                 "White is not always light and black is not always dark. – Habeeb Akande", "Life becomes easier when you learn to accept the apology you never got. – R. Brault", "Happiness depends upon ourselves. – Aristotle",
                                 "Turn your wounds into wisdom. – Oprah Winfrey", "Change the game, don’t let the game change you. – Macklemore", "It hurt because it mattered. – John Green", "If the world was blind how many people would you impress? – Boonaa Mohammed",
                                 "I will remember and recover, not forgive and forget. – Unknown", "The meaning of life is to give life meaning. – Ken Hudgins", "The true meaning of life is to plant trees, under whose shade you do not expect to sit. – Nelson Henderson",
                                 "When words fail, music speaks. – Shakespeare", "Embrace the glorious mess that you are. – Elizabeth Gilbert", "Normality is a paved road: it’s comfortable to walk but no flowers grow. – Vincent van Gogh",
                                 "I have nothing to lose but something to gain. – Eminem", "I may not have gone where I intended to go, but I think I have ended up where I needed to be. – Douglas Adams.", "When in doubt, look intelligent. - Garrison Keillor",
                                 "Don't take life seriously, no one makes it out alive. - Elbert Hubbard"}

        Dim VS As String
          Dim RndIndx As Integer
          Dim length As Integer
          Dim RandomClas As New Random
          length = RDQ.Length - 1
          RndIndx = RandomClas.Next(0, length)
          VS = RDQ(RndIndx)
          Return VS

     End Function





End Class