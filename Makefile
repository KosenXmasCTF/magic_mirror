MAKE=make
MKDIR=mkdir
DOTNET=dotnet

all:
	${MKDIR} -p ./dist
	${MAKE} generate
	${MAKE} solve

generate:
	${DOTNET} run generate

solve:
	${DOTNET} run solve
