using src.Concepts.Delegates;

MessageService messageService = new MessageService();

BasicDelegate myDelegate = messageService.SayHello;

myDelegate("World");


