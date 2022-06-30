# Refactoring Kata

## Goal
The goal of this kata is to find the code smells of this legacy code and fix them in the safest way.

If you are confident with unit testing, we highly recommend to write some tests before refactoring the legacy code.
This legacy code is not so testable, it's highly probable that you need to make some changes to the code before you can write your test.
But try to reduce to the maximum the changes to make the code testable.

Feel free to use another framework test or any mock library.
If you feel that you are not able to put under tests this messy code, go straight to the refactoring without testing.

## 1 - Specification
The MoneyPot service (WalletKata/Wallets/WalletService.cs, method GetWalletsByUser) allows an user to consult the wallets of a friend.

1. If the user is not logged, the service throws a UserNotLoggedInException.
2. If the logged user is not friend with the user passed in argument, the service returns an empty list.
3. If the logged user is friend with the user passed in argument, the service returns the list of wallets fetched from the database.

Info : the database and the session is a stub which throws an exception.

## 2 - Setup Host
If you have time, please try to setup and configure an host in CodingKata.Console/Program.cs using the current solution. The goal of configuring this host is to use GetWalletsByUser and GetWalletDetails methods in the cleanest way possible.