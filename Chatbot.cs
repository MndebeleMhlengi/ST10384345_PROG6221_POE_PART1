using System;

namespace CyberSecurityBot
{
    public class Chatbot
    {
        private User user;

        public void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nHi there! What’s your name? ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name can’t be empty. Try again: ");
                name = Console.ReadLine();
            }

            user = new User { Name = name.Trim() };
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nWelcome, {user.Name}! 👋");
            Console.ResetColor();
        }

        public void StartChat()
        {
            Console.WriteLine("\nAsk me anything about cybersecurity (type 'exit' to quit):");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                string input = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("🤖: I didn’t quite catch that. Could you rephrase?");
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("🤖: Stay safe online! Thank you fr your time!👋");
                    break;
                }

                string response = GetChatbotResponse(input);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"🤖: {response}");
                Console.ResetColor();
            }
        }

        private string GetChatbotResponse(string query)
        {
            query = query.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                return "I didn't quite understand that. Could you rephrase?";
            }

            if (query.Contains("how are you"))
            {
                return "I'm doing well, thank you for asking!";
            }
            else if (query.Contains("what's your purpose") || query.Contains("what is your purpose"))
            {
                return "My purpose is to provide you with information and raise awareness about cybersecurity topics.";
            }
            else if (query.Contains("what can i ask you about"))
            {
                return "You can ask me about topics like password safety, phishing, safe browsing, malware, social engineering, and general online security tips.";
            }
            else if (query.Contains("password safety") || query.Contains("strong password"))
            {
                return "For strong password safety, use a combination of uppercase and lowercase letters, numbers, and symbols. Avoid using personal information and aim for a password that is at least 12 characters long. Consider using a password manager and enable multi-factor authentication (MFA).";
            }
            else if (query.Contains("phishing"))
            {
                return "Phishing is a type of online fraud where attackers try to trick you into revealing personal information, such as passwords or credit card details, often through deceptive emails or websites. Be cautious of unsolicited messages and always verify the sender's authenticity. Look for suspicious links and never provide sensitive info via email.";
            }
            else if (query.Contains("safe browsing") || query.Contains("browse safely"))
            {
                return "To browse safely, keep your web browser and antivirus software up to date. Be wary of suspicious links and websites, and avoid downloading files from untrusted sources. Use HTTPS for secure connections when entering sensitive information. Avoid public Wi-Fi for sensitive tasks.";
            }
            else if (query.Contains("malware"))
            {
                return "Malware is malicious software designed to damage or disrupt systems. Avoid downloading files from untrusted sources, use antivirus software, and be cautious of email attachments. Regularly update your software to patch vulnerabilities.";
            }
            else if (query.Contains("social engineering"))
            {
                return "Social engineering is the manipulation of people to gain access to sensitive information. Be cautious of unsolicited requests for personal information, and verify the identity of anyone asking for such details. Never share passwords or sensitive data with unknown parties.";
            }
            else if (query.Contains("data privacy"))
            {
                return "Data privacy is crucial. Be mindful of the information you share online, and understand the privacy policies of the services you use. Use strong passwords, enable MFA, and limit the amount of personal data you provide. Keep your software updated.";
            }
            else if (query.Contains("mobile security"))
            {
                return "For mobile security, use a strong passcode or biometric authentication. Only download apps from official app stores. Keep your device's operating system updated and be cautious of public Wi-Fi. Review app permissions regularly.";
            }
            else if (query.Contains("ransomware"))
            {
                return "Ransomware is a type of malware that encrypts your files and demands payment for their release. Regularly back up your data, avoid clicking on suspicious links or attachments, and keep your software updated to prevent ransomware attacks.";
            }
            else
            {
                return "I didn't quite understand that. Could you rephrase your question or ask about password safety, phishing, safe browsing, malware, social engineering, or data privacy?";
            }
        }
    }
}
