using MyConsoleApp.src.OoPrinciples.Coupling;
using OopPrinciples.Coupling;

var EmailOrder = new Order(new EmailSender());
EmailOrder.ProcessOrder();
var SmsOrder = new Order(new SmsSender());
SmsOrder.ProcessOrder();