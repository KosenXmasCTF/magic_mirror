MAKE=make
DOTNET=dotnet

all:
	${MAKE} generate
	${MAKE} solve

generate:
	${DOTNET} run generate

solve:
	${DOTNET} run solve
