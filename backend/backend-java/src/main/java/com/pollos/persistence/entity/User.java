package com.pollos.persistence.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table (name = "users")
public class User {

  @Id
  @GeneratedValue (strategy = GenerationType.IDENTITY)
  private Integer id;

  private String dni;

  private String name;

  @Column (name = "father_last_name")
  private String fatherLastName;

  @Column (name = "mother_last_name")
  private String motherLastName;

  @Column (name = "birth_date")
  private String birthDate;

  private String telephone;

  private String address;

  private String email;

  private String username;

  private String password;

  @Column (name = "creation_date", insertable = false, updatable = false)
  private String creationDate;

  @Column (name = "update_date", insertable = false, updatable = false)
  private String updateDate;

  @Column (name = "created_by", updatable = false)
  private String createdBy;

  @Column (name = "updated_by", updatable = false)
  private String updatedBy;

  //Getters and Seeters id
  public Integer getId() {
    return id;
  }

  public void setId(Integer id) {
    this.id = id;
  }

  //Getters and Seeters dni
  public String getDni() {
    return dni;
  }

  public void setDni(String dni) {
    this.dni = dni;
  }

  //Getters and Seeters name
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  //Getters and Seeters fatherLastName
  public String getFatherLastName() {
    return fatherLastName;
  }

  public void setFatherLastName(String fatherLastName) {
    this.fatherLastName = fatherLastName;
  }

  //Getters and Seeters motherLastName
  public String getMotherLastName() {
    return motherLastName;
  }

  public void setMotherLastName(String motherLastName) {
    this.motherLastName = motherLastName;
  }

  //Getters and Seeters birthDate
  public String getBirthDate() {
    return birthDate;
  }

  public void setBirthDate(String birthDate) {
    this.birthDate = birthDate;
  }

  //Getters and Seeters telephone
  public String getTelephone() {
    return telephone;
  }

  public void setTelephone(String telephone) {
    this.telephone = telephone;
  }

  //Getters and Seeters address
  public String getAddress() {
    return address;
  }

  public void setAddress(String address) {
    this.address = address;
  }

  //Getters and Seeters email
  public String getEmail() {
    return email;
  }

  public void setEmail(String email) {
    this.email = email;
  }

  //Getters and Seeters username
  public String getUsername() {
    return username;
  }

  public void setUsername(String username) {
    this.username = username;
  }

  //Getters and Seeters password
  public String getPassword() {
    return password;
  }

  public void setPassword(String password) {
    this.password = password;
  }

  //Getters and Seeters creationDate
  public String getCreationDate() {
    return creationDate;
  }

  public void setCreationDate(String creationDate) {
    this.creationDate = creationDate;
  }

  //Getters and Seeters updateDate
  public String getUpdateDate() {
    return updateDate;
  }

  public void setUpdateDate(String updateDate) {
    this.updateDate = updateDate;
  }

  //Getters and Seeters createdBy
  public String getCreatedBy() {
    return createdBy;
  }

  public void setCreatedBy(String createdBy) {
    this.createdBy = createdBy;
  }

  //Getters and Seeters updatedBy
  public String getUpdatedBy() {
    return updatedBy;
  }

  public void setUpdatedBy(String updatedBy) {
    this.updatedBy = updatedBy;
  }
}
