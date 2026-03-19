// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include "TestSubsystem.generated.h"

/**
 * 
 */
UCLASS(Abstract, Blueprintable)
class BLUEPRINTSUBSYSTEM_API UTestSubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void MyFunction();
	
};
